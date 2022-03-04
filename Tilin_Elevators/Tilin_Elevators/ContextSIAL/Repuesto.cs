using System;
using System.Collections.Generic;

namespace Tilin_Elevators.ContextSIAL
{
    public partial class Repuesto
    {
        public Repuesto()
        {
            ReparacionxRepuestos = new HashSet<ReparacionxRepuesto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string NumeroSerie { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Fabricante { get; set; }
        public int Cantidad { get; set; }
        public string? TiempoSuministro { get; set; }

        public virtual ICollection<ReparacionxRepuesto> ReparacionxRepuestos { get; set; }
    }
}
