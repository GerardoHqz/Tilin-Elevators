using System;
using System.Collections.Generic;

#nullable disable

namespace Elevators_Tilin.ContextSIAL
{
    public partial class Automovil
    {
        public Automovil()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
            Reparacions = new HashSet<Reparacion>();
        }

        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Combustuble { get; set; }
        public int Anio { get; set; }
        public string Marca { get; set; }

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
        public virtual ICollection<Reparacion> Reparacions { get; set; }
    }
}
