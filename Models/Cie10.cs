using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCalidadSoft.Models
{
  
    public partial class Cie10
    {
        
        public Cie10()
        {
            DiagnosticoMedico = new List<DiagnosticoMedico>();
        }
     
        
        [Key]
        public string Codigo { get; set; }

        [Column(TypeName = "text")]
        public string Descripcion { get; set; }

       public virtual List<DiagnosticoMedico> DiagnosticoMedico { get; set; }
    }
}
