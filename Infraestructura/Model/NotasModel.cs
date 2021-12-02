using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Model
{
    public class NotasModel : BaseModel<Notas>, INotas
    {
        public decimal CalcularNotaFinal(decimal IP, decimal IIP, decimal Sistematicos, decimal Tarea)
        {
            return IP + IIP + Sistematicos + Tarea;
        }

        public List<Notas> Promedios(List<Notas> e)
        {
            throw new NotImplementedException();
        }
    }
}
