using PrincipiosSolid.OpenClosed.Correcto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrecto
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
                if (coche.GetType() == typeof(Renault)) { Console.WriteLine(numAsientosRenault(coche)); }
                if (coche.GetType() == typeof(Audi)) { Console.WriteLine(numAsientosAudi(coche)); }
                if (coche.GetType() == typeof(Mercedes)) { Console.WriteLine(numAsientosMercedes(coche)); }
            }
        }
        
        public static int numAsientosRenault(Coche coche) 
        {
            if (coche.GetType() == typeof(Renault)) { return 5; }
            else { throw new Exception("El coche no es Renault"); }
        }

        public static int numAsientosAudi(Coche coche)
        {
            if (coche.GetType() == typeof(Audi)) { return 4; }
            else { throw new Exception("El coche no es Audi"); }
        }

        public static int numAsientosMercedes(Coche coche)
        {
            if (coche.GetType() == typeof(Mercedes)) { return 6; }
            else { throw new Exception("El coche no es Mercedes"); }
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