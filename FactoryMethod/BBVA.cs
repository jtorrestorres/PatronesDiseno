using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //The BankOne charges 2% on credit cards if the order is less that 50 USD and 1% if it is more than 50 USD. 
    public class BBVA : IPasarelaDePago
    {
        public void RealizarPago(Producto producto)
        {
            // The bank specific API call to make the payment
            Console.WriteLine("Using bank1 to pay for {0}, amount {1}", producto.Name, producto.Price);
        }
    }

   
}
