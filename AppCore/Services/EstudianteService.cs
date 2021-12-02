using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class EstudianteService : IEstudianteService
    {
        private IEstudiante estudiantemodel;
        public void Create(Estudiantes e)
        {
            estudiantemodel.Create(e);
        }

        public void Delete(Estudiantes e)
        {
            estudiantemodel.Delete(e);
        }

        public List<Estudiantes> GetAll()
        {
            return estudiantemodel.GetAll();
        }

        public List<Estudiantes> GetAllBy(Predicate<Estudiantes> predicate)
        {
            return estudiantemodel.GetAllBy(predicate);
        }

        public Estudiantes GetAnyBy(Predicate<Estudiantes> predicate)
        {
            return estudiantemodel.GetAnyBy(predicate);
        }

        public void Update(int index, Estudiantes a)
        {
            estudiantemodel.Update(index, a);
        }
    }
}
