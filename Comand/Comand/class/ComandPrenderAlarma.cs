using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand.Iter;

namespace Comand
{
    class ComandPrenderAlarma : IComand
    {
        Automovil auto;

        public ComandPrenderAlarma(Automovil pAuto)
        {
            this.auto = pAuto;
        }


        public void ejecutar()
        {
            auto.ColocarAlarma();
        }

    }
}
