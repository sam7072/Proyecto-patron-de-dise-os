using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comand.Iter;

namespace Comand
{
    class ComandApagarAlarma : IComand
    {
        Automovil auto;

        public ComandApagarAlarma(Automovil pAuto)
        {
            this.auto = pAuto;
        }

        public void ejecutar()
        {
            auto.QuitarAlarma();
        }
    }
}
