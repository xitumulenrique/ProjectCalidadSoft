using ProjectCalidadSoft.Data.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCalidadSoft.Models
{
    public class Medicamento
    {

        public Medicamento() {

            Prescripcion = new List<Prescripcion>();
        }

        [Key]
        public int IdMedicamento { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Prescripcion> Prescripcion { get; set; }
  
    }
}
