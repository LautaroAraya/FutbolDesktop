using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Equipos;
using FutbolDesktop.Views.Commons.Jugadores;
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
    public partial class JugadoresView : Form
    {
        IGenericService<Jugador> jugadorService = new GenericService<Jugador>();
        public JugadoresView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridViewJugadores.DataSource = await jugadorService.GetAllAsync();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarEditarJugadores agregarEditarJugadoresView = new AgregarEditarJugadores();
            agregarEditarJugadoresView.ShowDialog();

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridViewJugadores.CurrentRow.Cells[0].Value;
            var nombreEliminar = (string)dataGridViewJugadores.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al Jugador {nombreEliminar}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                jugadorService.DeleteAsync(idEliminar);
                CargarGrilla();
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridViewJugadores.CurrentRow.Cells[0].Value;
            AgregarEditarJugadores agregarEditarJugadores = new AgregarEditarJugadores(idEditar);
            agregarEditarJugadores.ShowDialog();
            CargarGrilla();
        }
    }
}
