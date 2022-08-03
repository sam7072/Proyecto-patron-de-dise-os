using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand;
using Comand.Iter;

namespace Comand
{
    class ComandEncender : IComand
    {
        Automovil auto;

        public ComandEncender(Automovil pAuto)
        {
            this.auto = pAuto;
        }

         public void ejecutar()
        {
            //invocar la accion correspondiente del auto
            auto.Encender();
        }
    }
}
