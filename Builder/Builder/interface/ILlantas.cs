using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface ILlantas
{
        string informacion();
}

    //los tipos de llantas 

    class llantas12 : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 17 pulgadas";
        }
    }

    class llantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 18 pulgadas, rines aluminio";
        }
    }

    class llantasEconomica : ILlantas
    {
        public string informacion()
        {
            return "Llantas de 16 pulgadas";
        }
    }
}
