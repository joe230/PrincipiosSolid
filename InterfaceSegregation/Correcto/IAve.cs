using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Correcto
{
    public interface IAve
    {
        void comer();
    }
    public interface IAveVoladora
    {
        void volar();
    }
    public interface IAveNadadora
    {
        void nadar();
    }

    public class Loro : IAve, IAveVoladora
    {
        public void comer()
        {
            
        }

        public void volar()
        {
            
        }
    }

    public class Pinguino : IAve, IAveNadadora
    {
        public void comer()
        {
            
        }

        public void nadar()
        {
            
        }
    }
}
