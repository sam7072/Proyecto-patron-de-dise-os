using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Constructores
{
    class BuilderDeportivo : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrullerMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }
        
        public void ConstrullerLlantas()
        {
            auto.ColocarLlantas(new llantasSuper());
        }

        public void ConstrullerCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }

    }
}
