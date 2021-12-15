using System;
using System.Collections.Generic;

#nullable disable

namespace Elevators_Tilin.ContextSIAL
{
    public partial class Repuesto
    {
        public Repuesto()
        {
            ReparacionxRepuestos = new HashSet<ReparacionxRepuesto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public int Cantidad { get; set; }
        public double? Precio { get; set; }
        public TimeSpan? TiempoSuministro { get; set; }

        public virtual ICollection<ReparacionxRepuesto> ReparacionxRepuestos { get; set; }
    }
}
