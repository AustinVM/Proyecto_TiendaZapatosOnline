using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Facturacion
{
    public class Ce_DetallesFactura
    {
        public int id { get; set; }
        public int id_Producto_Talla { get; set; }
        public string descripcion { get; set; }
        public int id_TipoPago { get; set; }
        public int id_Iva { get; set; }
        public int subtotal { get; set; }
        public int total { get; set; }

        public Ce_DetallesFactura()
        {
            id = 0;
            id_Producto_Talla = 0;
            descripcion = "";
            id_TipoPago = 0;
            id_Iva = 0;
            subtotal = 0;
            total = 0;
        }
    }
}
