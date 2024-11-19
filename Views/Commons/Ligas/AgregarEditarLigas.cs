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

namespace FutbolDesktop.Views.Commons.Ligas
{
    public partial class AgregarEditarLigas : Form
    {
        IGenericService<Liga> ligaService = new GenericService<Liga>();
        private Liga Ligas;
        public AgregarEditarLigas()
        {
            InitializeComponent();
            Ligas = new Liga();
        }
        public AgregarEditarLigas(int idEditar)
        {
            InitializeComponent();
            CargarDatosAEditar(idEditar);
        }

        private async void CargarDatosAEditar(int idEditar)
        {
            Ligas = await ligaService.GetByIdAsync(idEditar);

            if (Ligas != null)
            {
                txtNombre.Text = Ligas.Nombre;
            }
            else
            {
                MessageBox.Show("No se encontró la Liga con el ID especificado.");
            }
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Ligas.Nombre = txtNombre.Text;
            if (Ligas.Id == 0)
            {
                ligaService.AddAsync(Ligas);
            }
            else
            {
                ligaService.UpdateAsync(Ligas);
            }
            MessageBox.Show("Liga agregada correctamente", "Liga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
