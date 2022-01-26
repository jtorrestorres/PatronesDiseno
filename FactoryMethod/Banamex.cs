using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //BankTwo on the other hand charges flat 1.5% for all the amounts.
    public class Banamex : IPasarelaDePago
    {
        public void RealizarPago(Producto producto)
        {
            // The bank specific API call to make the payment
            Console.WriteLine("Using bank2 to pay for {0}, amount {1}", producto.Name, producto.Price);
        }
    }
}
