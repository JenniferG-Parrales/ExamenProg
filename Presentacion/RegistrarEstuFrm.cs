using AppCore.Interfaces;
using Domain.Entities;
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
    public partial class RegistrarEstuFrm : Form
    {
        IEstudianteService estudianteService;
        public int count { get; set; }
        public RegistrarEstuFrm()
        {
            InitializeComponent();
        }

        private void BtnRegresaralMenu_Click(object sender, EventArgs e)
        {
            MenuFrm RMenu = new MenuFrm();
            RMenu.Show();
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            Estudiantes a = new Estudiantes()
            {
                Id = ++count,
                Nombres = txtBoxNombrs.Text,
                Apellidos = txtBoxApellids.Text,
                Carnet = txtBoxCarnet.Text,
                Municipio = DeterminarMunicipio(cmbBoxMunicipio.SelectedIndex),
            };
            estudianteService.Create(a);
        }
        
        private string DeterminarMunicipio(int i)
        {
            if(i == 0)
            {
                return "Managua";
            } else if(i== 1)
            {
                return "Masaya";
            } else if (i == 2)
            {
                return "Diriamba";
            } else if (i == 3)
            {
                return "Jinotepe";
            } else if (i == 4)
            {
                return "Blufields";
            } else if (i == 5)
            {
                return "Ciudad Sandino";
            }
            return null;
        }

    }
}
