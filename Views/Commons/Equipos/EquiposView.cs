using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Entrenadores;
using FutbolDesktop.Views.Commons.Equipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views
{
    public partial class EquiposView : Form
    {
        IGenericService<Equipo> equipoService = new GenericService<Equipo>();
        IGenericService<Entrenador> entrenadorService = new GenericService<Entrenador>();
        public EquiposView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            try
            {
                var equipos = await equipoService.GetAllAsync();
                var equipoConDetalles = new List<dynamic>();

                foreach (var equipo in equipos)
                {
                    var entrenador = await ObtenerEntrenadorPorIdAsync(equipo.EntrenadorId);

                    // Agregar detalles al listado
                    equipoConDetalles.Add(new
                    {
                        equipo.Id,
                        equipo.Nombre,
                        equipo.Estadio,
                        Entrenador = entrenador?.Nombre ?? "Entrenador desconocido"
                    });
                }

                // Asignar datos al DataGridView
                dataGridViewEquipos.DataSource = null; // Limpiar para refrescar
                dataGridViewEquipos.DataSource = equipoConDetalles;

                // Configurar encabezados y diseño
                dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Entrenador> ObtenerEntrenadorPorIdAsync(int EntrenadorId)
        {
            try
            {
                return await entrenadorService.GetByIdAsync(EntrenadorId);
            }
            catch
            {
                return null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridViewEquipos.CurrentRow.Cells[0].Value;
            var nombreEliminar = (string)dataGridViewEquipos.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al Equipo {nombreEliminar}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                equipoService.DeleteAsync(idEliminar);
                CargarGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar_EditarEquipos agregarEditarEquipos = new Agregar_EditarEquipos();
            agregarEditarEquipos.ShowDialog();
            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridViewEquipos.CurrentRow.Cells[0].Value;
            Agregar_EditarEquipos agregarEditarEquipos = new Agregar_EditarEquipos(idEditar);
            agregarEditarEquipos.ShowDialog();
            CargarGrilla();
        }
    }
}
