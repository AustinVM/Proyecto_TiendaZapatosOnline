using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Facturacion
{
    public class Ce_Factura
    {
        public int id { get; set; }
        public DateTime FchExpedicion { get; set; }
        public string id_Cliente { get; set; }
        public int id_DetallesFactura { get; set; }
        public int id_Municipio { get; set; }

        public Ce_Factura()
        {
            id = 0;
            FchExpedicion = DateTime.Today;
            id_Cliente = "";
            id_DetallesFactura = 0;
            id_Municipio = 0;
        }
    }
}
