using System;

namespace ProjectCalidadSoft.Controllers
{
    public class QueryDiagnostico
    {
        public string descripcion { get; set; }
        public DateTime fecha { get; set; }
        public string codigoCie { get; set; }
        public int codigoPaciente { get; set; }
    }
}