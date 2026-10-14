using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Como te llamas: ");
            string entrada = Console.ReadLine() ?? "";
            string nombre = string.IsNullOrWhiteSpace(entrada) ? "Invitado" : entrada;
            Console.WriteLine("Cual es tu edad: ");
            entrada = Console.ReadLine() ?? "";
            int edad = string.IsNullOrWhiteSpace(entrada) ? 0 : Convert.ToInt32(entrada);
            Console.WriteLine("Tienes mascotas 1-Si 2-No: ");
            entrada = Console.ReadLine() ?? "";
            int respuesta = string.IsNullOrWhiteSpace(entrada) ? 0 : Convert.ToInt32(entrada);

            Console.WriteLine($"Tu nombre es {nombre} tienes {edad} años y {respuesta} mascotas");
        }
    }
}
