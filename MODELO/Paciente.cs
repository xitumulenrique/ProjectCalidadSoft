﻿using System;
using System.Collections.Generic;

namespace ProjectCalidadSoft.MODELO
{
    public partial class Paciente
    {
        public Paciente()
        {
            DiagnosticoMedico = new HashSet<DiagnosticoMedico>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string LugarNacimiento { get; set; }
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
        public DateTime FechaNacimieto { get; set; }

        public virtual ICollection<DiagnosticoMedico> DiagnosticoMedico { get; set; }
    }
}
