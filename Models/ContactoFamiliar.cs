using System;
using System.Collections.Generic;

namespace ProjectCalidadSoft.Models
{
    public partial class ContactoFamiliar
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Relacion { get; set; }
    }
}
