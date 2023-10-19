using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Incorrecto
{
    public class Coche
    {
        public String marca;

        public Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }

        public static void main(String[] args)
        {
            Coche[] arrayCoches = {
                new Coche("Renault"),
                new Coche("Audi")
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                if (coche.marca.Equals("Renault")) Console.WriteLine(18000);
                if (coche.marca.Equals("Audi")) Console.WriteLine(25000);
            }
        }
    }
}
