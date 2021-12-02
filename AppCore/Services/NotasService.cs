using AppCore.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Services
{
    public class NotasService : INotasService
    {
        private INotas notasModel;

        public decimal CalcularNotaFinal(decimal IP, decimal IIP, decimal Sistematicos, decimal Tarea)
        {
            return notasModel.CalcularNotaFinal(IP, IIP, Sistematicos, Tarea);
        }

        public void Create(Notas e)
        {
            notasModel.Create(e);
        }

        public void Delete(Notas e)
        {
            notasModel.Delete(e);
        }

        public List<Notas> GetAll()
        {
            return notasModel.GetAll();
        }

        public List<Notas> GetAllBy(Predicate<Notas> predicate)
        {
            return notasModel.GetAllBy(predicate);
        }

        public Notas GetAnyBy(Predicate<Notas> predicate)
        {
            return notasModel.GetAnyBy(predicate);
        }

        public void Update(int index, Notas a)
        {
            notasModel.Update(index, a);
        }
    }
}
