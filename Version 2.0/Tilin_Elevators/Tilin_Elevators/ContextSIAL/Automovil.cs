using System;
using System.Collections.Generic;

namespace Tilin_Elevators.ContextSIAL
{
    public partial class Automovil
    {
        public Automovil()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
            Reparacions = new HashSet<Reparacion>();
        }

        public int Id { get; set; }
        public string Placa { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public string Combustuble { get; set; } = null!;
        public int Anio { get; set; }
        public DateTime? ContratoInicio { get; set; }
        public DateTime? ContratoFinal { get; set; }
        public string Marca { get; set; } = null!;

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
        public virtual ICollection<Reparacion> Reparacions { get; set; }
    }
}
