using System;
using System.Collections.Generic;

namespace ProjectCalidadSoft.MODELO
{
    public partial class DiagnosticoMedico
    {
        public string CodigoCie10 { get; set; }
        public int IdPaciente { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Cie10 CodigoCie10Navigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
