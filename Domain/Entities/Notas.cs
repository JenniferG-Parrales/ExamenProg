using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Notas
    {
        public Asignatura asignatura { get; set; }
        public Estudiantes estudiante { get; set; }
        public int sistematico { get; set; }
        public int IParcial { get; set; }
        public int IIParcial { get; set; }
        public int Tarea { get; set; }
        public int NotaFinal { get; set; }
    }
}
