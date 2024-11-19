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

namespace FutbolDesktop.Views.Commons.Jugadores
{
    public partial class AgregarEditarJugadores : Form
    {
        IGenericService<Jugador> jugadorService = new GenericService<Jugador>();
        private Jugador jugador;
        public AgregarEditarJugadores()
        {
            InitializeComponent();
            jugador = new Jugador();
        }
        public AgregarEditarJugadores(int idEditar)
        {
            InitializeComponent();
            CargarDatosAEditar(idEditar);
        }

        private async void CargarDatosAEditar(int idEditar)
        {
            jugador = await jugadorService.GetByIdAsync(idEditar);

            if (jugador != null)
            {
                txtNombre.Text = jugador.Nombre;
                txtPosicion.Text = jugador.Posicion;
                txtNombreEquipo.Text = jugador.Equipo;
            }
            else
            {
                MessageBox.Show("No se encontró el Jugador con el ID especificado.");
            }
        }

        private async void AgregarBtn_Click(object sender, EventArgs e)
        {
            jugador.Nombre = txtNombre.Text;
            jugador.Posicion = txtPosicion.Text;
            jugador.Equipo = txtNombreEquipo.Text;
            if (jugador.Id == 0)
            {
                await jugadorService.AddAsync(jugador);
            }
            else
            {
                await jugadorService.UpdateAsync(jugador);
            }
            MessageBox.Show("Jugador agregado correctamente", "Jugador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
