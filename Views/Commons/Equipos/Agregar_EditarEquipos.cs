using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Entrenadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views.Commons.Equipos
{
    public partial class Agregar_EditarEquipos : Form
    {
        private readonly IGenericService<Equipo> equipoService = new GenericService<Equipo>();
        private readonly
        IGenericService<Entrenador> entrenadorService = new GenericService<Entrenador>();
        private Equipo equipo;
        private List<Entrenador> entrenadores;
        public Agregar_EditarEquipos()
        {
            InitializeComponent();
            equipo = new Equipo();
            CargarEntrenador();
        }

        private async void CargarEntrenador()
        {
            try
            {
                entrenadores = await entrenadorService.GetAllAsync();
                cmbEntrenadores.DataSource = entrenadores;
                cmbEntrenadores.DisplayMember = "Nombre";
                cmbEntrenadores.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el Entrenador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Agregar_EditarEquipos(int idEditar)
        {
            InitializeComponent();
            CargarEntrenador();
            CargarDatosAEditar(idEditar);
        }

        private async void CargarDatosAEditar(int idEditar)
        {
            try
            {
                equipo = await equipoService.GetByIdAsync(idEditar);
                txtNombre.Text = equipo.Nombre;
                txtEstadio.Text = equipo.Estadio;
                cmbEntrenadores.SelectedValue = equipo.EntrenadorId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos a editar" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AgregarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                equipo.EntrenadorId = (int)cmbEntrenadores.SelectedValue;
                equipo.Nombre = txtNombre.Text;
                equipo.Estadio = txtEstadio.Text;

                if (equipo.Id == 0)
                {
                    await equipoService.AddAsync(equipo);
                }
                else
                {
                    await equipoService.UpdateAsync(equipo);

                }
                MessageBox.Show("Equipo agregado correctamente", "Equipo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Equipo" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarEntrenadorbtn_Click(object sender, EventArgs e)
        {
            AgregarEditarEntrenadores agregarEditarEntrenadores = new AgregarEditarEntrenadores();
            agregarEditarEntrenadores.ShowDialog();
            CargarEntrenador();
        }
    }
}
