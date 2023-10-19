using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    public abstract class Coche
    {
        public abstract int precioMedioCoche();
        public abstract int numAsientos();

        public static void main(String[] args)
        {
            Coche[] arrayCoches =
            {
                new Renault(),
                new Audi(),
                new Mercedes()
            };
            imprimirPrecioMedioCoche(arrayCoches);

            imprimirNumAsientos(arrayCoches);
        }
        
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (var coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
    }

    public class Renault : Coche
    {
        public override int precioMedioCoche() { return 18000; }
        public override int numAsientos() { return 5; }
    }

    public class Audi : Coche
    {
        public override int precioMedioCoche() { return 25000; }
        public override int numAsientos() { return 4; }
    }

    public class Mercedes : Coche
    {
        public override int precioMedioCoche() { return 27000; }
        public override int numAsientos() { return 6; }
    }
}
