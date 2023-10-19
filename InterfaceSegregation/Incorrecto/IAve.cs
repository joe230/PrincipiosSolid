using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Incorrecto
{
    public interface IAve
    {
        void volar();
        void comer();
        void nadar();
    }

    public class Loro : IAve
    {
        public void comer()
        {
            
        }

        public void nadar()
        {
            
        }

        public void volar()
        {
            
        }
    }

    public class Pinguino : IAve
    {
        public void comer()
        {
            
        }

        public void nadar()
        {
            
        }

        public void volar()
        {
            
        }
    }
}
