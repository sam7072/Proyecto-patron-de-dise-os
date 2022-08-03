using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand
{
    class Automovil
    {
        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("se ha encendido el auto");
        }

        public void Apagar()
        {
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine("se ha apagado el auto");
        }

        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("alarma encendida");
        }

        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("alarma apagada");
        }

    }
}
