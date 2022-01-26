using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        public class EstacioMeteorologica
        {
            private IMeteoReferencia termometro;
            public EstacioMeteorologica()
            {
                termometro = new Termometro();
            }
            public void MostrarDatos()
            {
                Console.WriteLine(
                string.Format("Datos a {0}", DateTime.Now));
                Console.WriteLine(termometro.Mostrar());
            }
        }
       

        public interface IMeteoReferencia
        {
            int Valor { get; set; }
            string Mostrar();
        }
        public class Termometro : IMeteoReferencia
        {
            public int Valor { get; set; }
            public string Mostrar()
            {
                return string.Format("Temperatura:{0} º", Valor);
            }
        }
        static void Main(string[] args)
        {

        }
    }

}
