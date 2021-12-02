using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuFrm : Form
    {
        public MenuFrm()
        {
            InitializeComponent();
        }

        private void BtnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            RegistrarEstuFrm Registrar = new RegistrarEstuFrm();
            Registrar.Show();
            this.Hide();
        }

        private void BtnIngresarNotas_Click(object sender, EventArgs e)
        {
            IngresarNotsFrm IngresaerNots = new IngresarNotsFrm();
            IngresaerNots.Show();
            this.Hide();
        }

        private void BtnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            BuscarEstuFrm BuscarEst = new BuscarEstuFrm();
            BuscarEst.Show();
            this.Hide();
        }
    }
}
