using Microsoft.VisualBasic.CompilerServices;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectCalidadSoft.Models
{
    public partial class Paciente
    {
        
        public Paciente()
        {
            DiagnosticoMedico = new List<DiagnosticoMedico>();
        }
        
        public int Id { get; set; }

        /* NOMBRES*/
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*|[a-zA-Z]* [a-zA-Z]* ",
     ErrorMessage = "Dato incorrecto.")]
        public string Nombre { get; set; }


        /* APELLIDOS*/
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"[a-zA-Z]*|[a-zA-Z]* [a-zA-Z]* ",
           ErrorMessage = "Dato incorrecto.")]

        public string Apellidos { get; set; }



        [Display(Name = "Dpi")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"([0-9]{4}\s[0-9]{5}\s[0-9]{4})|[0-9]{13}",
            ErrorMessage = "Dato incorrecto.")]

        public string Dpi { get; set; }

        public string Sexo { get; set; }


        [Column(TypeName = "text")]
        public string LugarNacimiento { get; set; }


        [Display(Name = "FechaNacimiento")]
        [Required(ErrorMessage = "Este campo es requerido.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimieto { get; set; }
        public string Ocupacion { get; set; }
        public int? TipoPaciente { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int? ContactoFamiliares { get; set; }
        public int? TipoSangre { get; set; }
        public int? Tutor { get; set; }
        public string Estado { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }

        public virtual List<DiagnosticoMedico> DiagnosticoMedico { get; set; }

    }
}
