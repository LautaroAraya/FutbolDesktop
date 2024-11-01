using FutbolDesktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void JugadoresBtn_Click(object sender, EventArgs e)
        {
            JugadoresView jugadoresView = new JugadoresView();
            jugadoresView.Show();
        }

        private void EntrenadoresBtn_Click(object sender, EventArgs e)
        {
            EntrenadoresView entrenadoresView = new EntrenadoresView();
            entrenadoresView.Show();
        }

        private void EquiposBtn_Click(object sender, EventArgs e)
        {
            EquiposView equiposView = new EquiposView();
            equiposView.Show();
        }

        private void PartidosBtn_Click(object sender, EventArgs e)
        {
            PartidosView partidosView = new PartidosView();
            partidosView.Show();
        }

        private void LigasBtn_Click(object sender, EventArgs e)
        {
            LigasView ligasView = new LigasView();
            ligasView.Show();
        }

        private void SalirSistemaBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
