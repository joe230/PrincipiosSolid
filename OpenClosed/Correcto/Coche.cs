using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosed.Correcto
{
    public abstract class Coche
    {
        public abstract int precioMedioCoche();

        public static void main(String[] args)
        {
            Coche[] arrayCoches = 
            {
                new Renault(),
                new Audi(),
                new Mercedes()
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
    }

    public class Renault : Coche
    {
        public override int precioMedioCoche() { return 18000; }
    }

    public class Audi : Coche
    {
        public override int precioMedioCoche() { return 25000; }
    }

    public class Mercedes : Coche
    {
        public override int precioMedioCoche() { return 27000; }
    }
}
