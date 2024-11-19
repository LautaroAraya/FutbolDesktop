using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views.Commons.Entrenadores
{
    public partial class AgregarEditarEntrenadores : Form
    {
        IGenericService<Entrenador> entrenadorService = new GenericService<Entrenador>();
        Entrenador entrenador;
        public AgregarEditarEntrenadores()
        {
            InitializeComponent();
            entrenador = new Entrenador();

        }
        public AgregarEditarEntrenadores(int idEditar)
        {
            InitializeComponent();
            CargarDatosEntrenadorAEditar(idEditar);
        }

        private async void CargarDatosEntrenadorAEditar(int idEditar)
        {

            entrenador = await entrenadorService.GetByIdAsync(idEditar);

            if (entrenador != null)
            {
                txtNombre.Text = entrenador.Nombre;
            }
            else
            {
                MessageBox.Show("No se encontró el Entrenador con el ID especificado.");
            }
        }

        private async void AgregarBtn_Click(object sender, EventArgs e)
        {
            entrenador.Nombre = txtNombre.Text;

            if (entrenador.Id == 0)
            {
                await entrenadorService.AddAsync(entrenador);
            }
            else
            {
                await entrenadorService.UpdateAsync(entrenador);
            }

            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
