using System;
using System.Collections.Generic;

#nullable disable

namespace Elevators_Tilin.ContextSIAL
{
    public partial class ReparacionxRepuesto
    {
        public int Id { get; set; }
        public int IdReparacion { get; set; }
        public int IdRepuesto { get; set; }

        public virtual Reparacion IdReparacionNavigation { get; set; }
        public virtual Repuesto IdRepuestoNavigation { get; set; }
    }
}
