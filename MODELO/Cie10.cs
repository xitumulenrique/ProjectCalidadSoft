using System;
using System.Collections.Generic;

namespace ProjectCalidadSoft.MODELO
{
    public partial class Cie10
    {
        public Cie10()
        {
            DiagnosticoMedico = new HashSet<DiagnosticoMedico>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<DiagnosticoMedico> DiagnosticoMedico { get; set; }
    }
}
