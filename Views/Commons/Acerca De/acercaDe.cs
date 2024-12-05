using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDesktop.Views.Commons.Acerca_De
{
    public partial class acercaDe : Form
    {
        public acercaDe()
        {
            InitializeComponent();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblInformacion.Text = "Proyecto creado por alumno de 3er año.\n" +
                                  "Materia: Programación II.\n" +
                                  "Nombre: Lautaro Martín Araya.\n" +
                                  "Profesor: Rubén Alejandro Ramírez.\n" +
                                  "Carrera: Técnico Superior en Desarrollo de Software.\n" +
                                  "v1.0\n" +
                                  "Año: 2024.";
        }
    }
}
