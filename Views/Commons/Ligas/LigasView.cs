using FutbolDesktop.Interface;
using FutbolDesktop.Modelos;
using FutbolDesktop.Service;
using FutbolDesktop.Views.Commons.Ligas;
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
    public partial class LigasView : Form
    {
        IGenericService<Liga> ligaService = new GenericService<Liga>();
        public LigasView()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            dataGridViewLigas.DataSource = await ligaService.GetAllAsync();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            AgregarEditarLigas agregarEditarLigasView = new AgregarEditarLigas();
            agregarEditarLigasView.ShowDialog();
            CargarGrilla();
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            var idEditar = (int)dataGridViewLigas.CurrentRow.Cells[0].Value;
            AgregarEditarLigas agregarEditarLigas = new AgregarEditarLigas(idEditar);
            agregarEditarLigas.ShowDialog();
            CargarGrilla();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            var idEliminar = (int)dataGridViewLigas.CurrentRow.Cells[0].Value;
            var nombreEliminar = (string)dataGridViewLigas.CurrentRow.Cells[1].Value;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar la Liga {nombreEliminar}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ligaService.DeleteAsync(idEliminar);
                CargarGrilla();
            }
        }
    }
}