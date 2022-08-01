using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public void Construye(IBuilder pConstructor)
        {
            //aqui el director indica los pasos para hacer la construccion

            pConstructor.ConstrullerMotor();
            pConstructor.ConstrullerCarroceria();
            pConstructor.ConstrullerLlantas();
        }

    }
}
