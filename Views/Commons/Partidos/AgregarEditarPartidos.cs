using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Equipos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views.Commons.Partidos
{
    public partial class AgregarEditarPartidos : Form
    {
        private readonly IGenericService<Partido> partidoService = new GenericService<Partido>();
        private readonly IGenericService<Equipo> equipoService = new GenericService<Equipo>();
        private Partido partido;
        private List<Equipo> equipos;

        public AgregarEditarPartidos()
        {
            InitializeComponent();
            partido = new Partido();
            CargarEquiposLocales();
            CargarEquiposVisitantes();
        }

        public AgregarEditarPartidos(int idEditar)
        {
            InitializeComponent();
            partido = new Partido();
            CargarEquiposLocales();
            CargarEquiposVisitantes();
            CargarDatosAEditar(idEditar);
        }

        private async void CargarEquiposLocales()
        {
            try
            {
                equipos = await equipoService.GetAllAsync();
                cmbLocal.DataSource = equipos;
                cmbLocal.DisplayMember = "Nombre";
                cmbLocal.ValueMember = "Id";
                cmbLocal.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al cargar los equipos locales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarEquiposVisitantes()
        {
            try
            {
                equipos = await equipoService.GetAllAsync();
                cmbVisitante.DataSource = equipos;
                cmbVisitante.DisplayMember = "Nombre";
                cmbVisitante.ValueMember = "Id";
                cmbVisitante.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al cargar los equipos visitantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarDatosAEditar(int idEditar)
        {
            try
            {
                partido = await partidoService.GetByIdAsync(idEditar);

                if (partido == null)
                {
                    MessageBox.Show("No se encontró el partido con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si los equipos han sido cargados antes de asignar valores
                if (cmbLocal.Items.Count > 0)
                    cmbLocal.SelectedValue = partido.EquipoLocalId != 0 ? partido.EquipoLocalId : -1;

                if (cmbVisitante.Items.Count > 0)
                    cmbVisitante.SelectedValue = partido.EquipoVisitanteId != 0 ? partido.EquipoVisitanteId : -1;

                if (partido.Fecha != DateTime.MinValue)
                    dateTimeFecha.Value = partido.Fecha;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                partido.EquipoLocalId = (int)cmbLocal.SelectedValue;
                partido.EquipoVisitanteId = (int)cmbVisitante.SelectedValue;
                partido.Fecha = dateTimeFecha.Value;

                if (partido.Id == 0)
                {
                    await partidoService.AddAsync(partido);
                }
                else
                {
                    await partidoService.UpdateAsync(partido);
                }

                MessageBox.Show("Partido agregado correctamente", "Partido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Partido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarEquipoBtn_Click(object sender, EventArgs e)
        {
            Agregar_EditarEquipos agregarEditarEquipos = new Agregar_EditarEquipos();
            agregarEditarEquipos.ShowDialog();
            CargarEquiposLocales();
            CargarEquiposVisitantes();
        }


    }
}
