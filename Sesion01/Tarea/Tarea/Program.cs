using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // EJERCICIO 1 - RELOG
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("EJERCICIO 1 - RELOG");
            Console.ResetColor();

            // Pedimos la cantidad de segundos para posteriormente hacer la converción
            Console.WriteLine("Digite la cantidada de segundos: ");
            string entradaSegundos = Console.ReadLine() ?? "";

            // Validamos que lo que el usuario ingrese si sea correcto
            if (int.TryParse(entradaSegundos, out int total_segundos) && total_segundos >= 0)
            {
                int horas = total_segundos / 3600;
                int restoHoras = total_segundos % 3600;
                int minutos = restoHoras / 60;
                int segundos = restoHoras % 60;

                Console.WriteLine($"RESULTADO: {horas} h {minutos} m {segundos} s");
            } 
            // En caso de que se ingrese un dato erroneo se indica el error
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Error: Ingrese un número de segundos válido.\n");
                Console.ResetColor();
            }

            // EJERCICIO 2 - TEMPERATURA
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("EJERCICIO 2 - TEMPERATURA");
            Console.ResetColor();

            // Pedimos la temperatura en C
            Console.WriteLine("Digite la temperatura en Celsius: ");
            string entradaTemperatura = Console.ReadLine() ?? "";

            // Validamos que lo que el usuario ingrese si sea correcto
            if (double.TryParse(entradaTemperatura, out double celsius))
            {
                double fahrentheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"RESULTADO: {celsius} equivalen a {fahrentheit:F1} fahrentheit ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR INGRESE UNA TEMPERATURA VALIDA");
                Console.ResetColor();
            }

            // EJERCICIO 3 - PROMEDIO
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("EJERCICIO 3 - PROMEDIO");
            Console.ResetColor();

            // Pedimos la nota 1
            Console.WriteLine("Digite la nota 1: ");
            bool okN1 = double.TryParse(Console.ReadLine() ?? "", out double nota1);

            // Pedimos la nota 2
            Console.WriteLine("Digite la nota 2: ");
            bool okN2 = double.TryParse(Console.ReadLine() ?? "", out double nota2);

            // Pedimos nota 3
            Console.WriteLine("Digite la nota 3: ");
            bool okN3 = double.TryParse(Console.ReadLine() ?? "", out double nota3);

            // Validamos que todo este correcto, si es asi hacemos el promedio, sino mostramos un mensaje de error
            if (okN1 && okN2 && okN3)
            {
                double promedio = (nota1 + nota2 + nota3) / 3;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"El promedio final es: {promedio:F1}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Error: Una o más notas ingresadas no son válidas.");
                Console.ResetColor();
            }
        }
    }
}
