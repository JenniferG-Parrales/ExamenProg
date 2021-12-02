using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructura.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EstudianteModel>().As<IEstudiante>();
            builder.RegisterType<NotasModel>().As<INotas>();

            builder.RegisterType<EstudianteService>().As<IEstudianteService>();
            builder.RegisterType<NotasService>().As<INotasService>();

            //var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuFrm());
        }
    }
}
