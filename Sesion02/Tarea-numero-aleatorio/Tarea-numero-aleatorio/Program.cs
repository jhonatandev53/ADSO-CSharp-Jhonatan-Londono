using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_numero_aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 100);

            Console.WriteLine("================================");
            Console.WriteLine("    ENCUENTRA EL NUMERO ALEATORIO  ");
            Console.WriteLine("================================");

            int i = 1;
            int numero;

            while (i <= 7)
            {
                do
                {
                    Console.WriteLine("Que numero es: \n");
                } while (!int.TryParse(Console.ReadLine(), out numero));


                if (numeroAleatorio > numero)
                {
                    Console.WriteLine("El numero es mayor");
                }

                else if (numeroAleatorio < numero)
                {
                    Console.WriteLine("El numero es menor");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"GANASTE el numero era : {numeroAleatorio} Lo lograste en {i} intentos");
                    Console.ResetColor();
                    break;
                }

                
                
                if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"PERDISTE, EL NUMERO ERA: {numeroAleatorio}");
                    Console.ResetColor();

                    break;
                }

                i++;


            }
        }
    }
}
