using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder 
{
    //solo pequema
    public interface ICarroceria
{
        string caracteristicas();
}

    class CarroceriaBasica : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de metal";
        }
    }

    class CarroceriaEspecial : ICarroceria
    {
        public string caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
    }

    class CarroceriaHibrida : ICarroceria
        {

        public string caracteristicas()
        {
            return "Carroceria hibrida ambiental";
        }

    }
}
