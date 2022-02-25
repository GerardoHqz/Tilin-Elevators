using System;
using System.Collections.Generic;

namespace Tilin_Elevators.ContextSIAL
{
    public partial class Equipo
    {
        public Equipo()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
            Reparacions = new HashSet<Reparacion>();
        }

        public int Id { get; set; }
        public string Marca { get; set; } = null!;
        public string NumeroSerie { get; set; } = null!;
        public DateTime? ContratoInicio { get; set; }
        public DateTime? ContratoFinal { get; set; }
        public string Direccion { get; set; } = null!;
        public double Velocidad { get; set; }
        public double Voltaje { get; set; }
        public int Niveles { get; set; }

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
        public virtual ICollection<Reparacion> Reparacions { get; set; }
    }
}
