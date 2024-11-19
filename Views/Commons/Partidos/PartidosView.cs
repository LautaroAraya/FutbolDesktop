using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Partidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views
{
    public partial class PartidosView : Form
    {
        private readonly IGenericService<Partido> partidoService = new GenericService<Partido>();
        private readonly IGenericService<Equipo> equipoService = new GenericService<Equipo>();

        public PartidosView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            try
            {
                var partidos = await partidoService.GetAllAsync();
                var partidoConDetalles = new List<dynamic>();

                foreach (var partido in partidos)
                {
                    // Obtener datos de los equipos locales y visitantes
                    var equipoLocal = await ObtenerEquipoPorIdAsync(partido.EquipoLocalId);
                    var equipoVisitante = await ObtenerEquipoPorIdAsync(partido.EquipoVisitanteId);

                    // Agregar detalles al listado
                    partidoConDetalles.Add(new
                    {
                        partido.Id,
                        EquipoLocal = equipoLocal?.Nombre ?? "Equipo desconocido",
                        EquipoVisitante = equipoVisitante?.Nombre ?? "Equipo desconocido",
                        Fecha = partido.Fecha.ToString("yyyy-MM-dd HH:mm") // Formato de fecha amigable
                    });
                }

                // Asignar datos al DataGridView
                dataGridViewPartidos.DataSource = null; // Limpiar para refrescar
                dataGridViewPartidos.DataSource = partidoConDetalles;

                // Configurar encabezados y diseño
                dataGridViewPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Equipo> ObtenerEquipoPorIdAsync(int equipoId)
        {
            try
            {
                return await equipoService.GetByIdAsync(equipoId);
            }
            catch
            {
                return null; // Manejar casos en los que no se encuentra el equipo
            }
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            var agregarEditarPartidosView = new AgregarEditarPartidos();
            agregarEditarPartidosView.ShowDialog();
            CargarGrilla();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPartidos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un partido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idEliminar = (int)dataGridViewPartidos.CurrentRow.Cells[0].Value;
                var equipoLocal = dataGridViewPartidos.CurrentRow.Cells[1].Value.ToString();
                var equipoVisitante = dataGridViewPartidos.CurrentRow.Cells[2].Value.ToString();

                var respuesta = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el partido entre {equipoLocal} y {equipoVisitante}?",
                    "Eliminar Partido",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    partidoService.DeleteAsync(idEliminar);
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPartidos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un partido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var idEditar = (int)dataGridViewPartidos.CurrentRow.Cells[0].Value;
                var agregarEditarPartidos = new AgregarEditarPartidos(idEditar);
                agregarEditarPartidos.ShowDialog();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
