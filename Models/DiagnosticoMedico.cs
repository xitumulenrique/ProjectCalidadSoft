using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCalidadSoft.Models
{
    public partial class DiagnosticoMedico
    {

       
        public int IdPaciente { get; set; }
        public Paciente Paciente{ get; set; }


        
        public string IdCie10 { get; set; }
        public Cie10 Cie10 { get; set; }





        public DateTime Fecha { get; set; }

       

    }
}
