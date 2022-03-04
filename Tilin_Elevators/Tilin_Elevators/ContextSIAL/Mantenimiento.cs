using System;
using System.Collections.Generic;

namespace Tilin_Elevators.ContextSIAL
{
    public partial class Mantenimiento
    {
        public int Id { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string NumeroSerie { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Tecnico { get; set; }
        public string Estado { get; set; } = null!;
        public int NumeroRegistro { get; set; }
        public int? IdEquipo { get; set; }
        public int? IdAutomovil { get; set; }

        public virtual Automovil? IdAutomovilNavigation { get; set; }
        public virtual Equipo? IdEquipoNavigation { get; set; }
    }
}
