using AppCore.Interfaces;
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
    public partial class BuscarEstuFrm : Form
    {
        private IEstudianteService estudianteService;
        public BuscarEstuFrm()
        {
            InitializeComponent();
        }

        private void BtnRegresaralMenu_Click(object sender, EventArgs e)
        {
            MenuFrm RMenu = new MenuFrm(estudianteService);
            RMenu.Show();
            this.Hide();
        }
    }
}
