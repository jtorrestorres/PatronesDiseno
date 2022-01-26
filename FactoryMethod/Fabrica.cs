using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
  
    public class Fabrica
    {

        public virtual IPasarelaDePago CrearTipoPago(int method, Producto producto)
        {
            IPasarelaDePago gateway = null;

            switch (method)
            {
                case 1:
                    gateway = new BBVA();
                    break;
                case 2:
                    gateway = new Banamex();
                    break;                
            }

          return gateway;
        }
    }
}
