using System;
using System.Collections.Generic;

#nullable disable

namespace Elevators_Tilin.ContextSIAL
{
    public partial class Equipo
    {
        public Equipo()
        {
            Mantenimientos = new HashSet<Mantenimiento>();
            Reparacions = new HashSet<Reparacion>();
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? ContratoInicio { get; set; }
        public DateTime? ContratoFinal { get; set; }
        public string Direccion { get; set; }
        public double Velocidad { get; set; }
        public double Voltaje { get; set; }
        public int Niveles { get; set; }

        public virtual ICollection<Mantenimiento> Mantenimientos { get; set; }
        public virtual ICollection<Reparacion> Reparacions { get; set; }
    }
}
