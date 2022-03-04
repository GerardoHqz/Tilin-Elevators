using System;
using System.Collections.Generic;

namespace Tilin_Elevators.ContextSIAL
{
    public partial class ReparacionxRepuesto
    {
        public int Id { get; set; }
        public int IdReparacion { get; set; }
        public int IdRepuesto { get; set; }

        public virtual Reparacion IdReparacionNavigation { get; set; } = null!;
        public virtual Repuesto IdRepuestoNavigation { get; set; } = null!;
    }
}
