using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface INotasService : IBaseService<Notas>
    {
        decimal CalcularNotaFinal(decimal IP, decimal IIP, decimal Sistematicos, decimal Tarea);
    }
}
