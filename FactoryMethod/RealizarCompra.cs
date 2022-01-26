using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RealizarCompra //1)
    {
        IPasarelaDePago pasarelaDePago = null;

        public void ProcesarPago(Producto producto)
        {
            Fabrica fabrica = new Fabrica();
            this.pasarelaDePago = fabrica.CrearTipoPago(1, producto);

            this.pasarelaDePago.RealizarPago(producto);
        }
    }
}
