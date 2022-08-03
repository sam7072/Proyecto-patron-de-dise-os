using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand.Iter;

namespace Comand
{
    class ControlRemoto
    {
        private IComand[] comands = new IComand[4];


        public ControlRemoto(Automovil pAuto)
        {
            comands[0] = new ComandEncender(pAuto);
            comands[1] = new ComandApagar(pAuto);
            comands[2] = new ComandPrenderAlarma(pAuto);
            comands[3] = new ComandApagarAlarma(pAuto);
            
        }

        public void Boton(int pIndice)
        {
            comands[pIndice].ejecutar();
        }

    }
}
