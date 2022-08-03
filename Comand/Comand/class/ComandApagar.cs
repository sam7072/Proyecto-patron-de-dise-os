using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand.Iter;

namespace Comand
{
    class ComandApagar : IComand
    {
        Automovil auto;

        public ComandApagar(Automovil pAuto)
        {
            this.auto = pAuto;
        }


        public void ejecutar()
        {
            auto.Apagar();
        }
    }
}
