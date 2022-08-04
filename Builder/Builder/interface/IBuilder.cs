using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        // acciones que llevan acavo los constructores
        public void ConstrullerMotor();
        public void ConstrullerCarroceria();
        public void ConstrullerLlantas();


    }
}
