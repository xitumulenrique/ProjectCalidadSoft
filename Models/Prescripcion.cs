using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCalidadSoft.Models
{
    public class Prescripcion
    {


        [Key]
        public int IdPrescripcion{ get; set; }
        public int Cantidad { get; set; }

        [Column(TypeName = "text")]
        public string Descripcion { get; set; }

       
        
        public int IdMedicamento { get; set; }

        public Medicamento Medicamento { get; set; }

        
        public int IdDiagnostico { get; set; }
        public DiagnosticoMedico DiagnosticoMedico { get; set; }

       
    }

}

