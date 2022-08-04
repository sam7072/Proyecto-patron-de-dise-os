using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Constructores
{
    class BuilderHíbrido : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrullerCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaHibrida());
        }

        public void ConstrullerLlantas()
        {
            auto.ColocarLlantas(new llantasEconomica());
        }

        public void ConstrullerMotor()
        {
            auto.ColocarMotor(new MotorTermico());
        }

        public Producto ObtenProducto()
        {
            return auto;
        }

    }


}
