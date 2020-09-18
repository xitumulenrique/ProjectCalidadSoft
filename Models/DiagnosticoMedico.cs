using System;
using System.Collections.Generic;

namespace ProjectCalidadSoft.Models
{
    public partial class DiagnosticoMedico
    {


        public virtual Cie10 CodigoCie10 { get; set; }
        public virtual Paciente IdPaciente { get; set; }
       

        public DateTime Fecha { get; set; }
    }
}
