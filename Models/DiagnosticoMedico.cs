using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCalidadSoft.Models
{
    public partial class DiagnosticoMedico
    {

        public DiagnosticoMedico() {
            Prescripcion = new List<Prescripcion>();

        }
        [Key]
        public int IdDiagnostico { get; set; }

        public int IdPaciente { get; set; }

        public Paciente Paciente { get; set; }

        public string IdCie10 { get; set; }
        public Cie10 Cie10 { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "Text")]
        public string Descripcion { get; set; }

        public virtual List<Prescripcion> Prescripcion { get; set; }



    }
}
