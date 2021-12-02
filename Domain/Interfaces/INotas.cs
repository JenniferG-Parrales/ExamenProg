using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface INotas : IBase<Notas>
    {
        List<Notas> Promedios(List<Notas> e);
        decimal CalcularNotaFinal(decimal IP, decimal IIP, decimal Sistematicos, decimal Tarea);
    }
}
