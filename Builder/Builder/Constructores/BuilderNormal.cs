using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Constructores
{
    class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrullerMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }
        
        public void ConstrullerLlantas()
        {
            auto.ColocarLlantas(new llantas12());
        }

        public void ConstrullerCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
