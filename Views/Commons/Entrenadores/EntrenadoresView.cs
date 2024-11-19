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

namespace FutbolDesktop.Views
{
    public partial class EntrenadoresView : Form
    {
        IGenericService<Entrenador> entrenadorService = new GenericService<Entrenador>();
        public EntrenadoresView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async void CargarGrilla()
        {
            dataGridViewEntrenadores.DataSource = await entrenadorService.GetAllAsync();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarEditarEntrenadores agregarEditarEntrenadores = new AgregarEditarEntrenadores();
            agregarEditarEntrenadores.ShowDialog();
            CargarGrilla();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridViewEntrenadores.CurrentRow.Cells[0].Value;
            AgregarEditarEntrenadores agregarEditarEntrenadores = new AgregarEditarEntrenadores(idEditar);
            agregarEditarEntrenadores.ShowDialog();
            CargarGrilla();

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridViewEntrenadores.CurrentRow.Cells[0].Value;
            var nombreEliminar = (string)dataGridViewEntrenadores.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al Entrenador {nombreEliminar}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                entrenadorService.DeleteAsync(idEliminar);
                CargarGrilla();
            }
        }
    }
}
