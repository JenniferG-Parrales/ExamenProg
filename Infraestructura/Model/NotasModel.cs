using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Model
{
    public class NotasModel : BaseModel<Notas>, INotas
    {
        public List<Notas> Promedios(List<Notas> e)
        {
            throw new NotImplementedException();
        }
    }
}
