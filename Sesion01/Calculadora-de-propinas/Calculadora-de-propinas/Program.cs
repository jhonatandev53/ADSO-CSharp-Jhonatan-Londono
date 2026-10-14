using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_propinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pidiendo el total de la cuenta
            Console.Write("Digite el total de la cuenta: ");
            string entrada = Console.ReadLine() ?? ""; // Creamos la variable entrada la cual vamos a reutilizar durante todo el codigo
            bool okTotal = decimal.TryParse(entrada, out decimal total_cuenta) && total_cuenta >= 0; // Estamos validando si lo que manda el usuario es correcto para manejar los errores

            // Pidiendo el porcentaje de propina
            Console.Write("Digite el porcentaje de propina (Sugerido 10%, 15% o 20%): ");
            entrada = Console.ReadLine() ?? "";
            bool okPropina = decimal.TryParse(entrada, out decimal porcentaje_propina) && porcentaje_propina >= 0;

            // Pidiendo el numero de personas
            Console.Write("Digite el numero de personas: ");
            entrada = Console.ReadLine() ?? "";
            bool okPersonas = int.TryParse(entrada, out int numero_personas) && numero_personas > 0;

            // Dejamos un espacio en blanco
            Console.WriteLine();

            // Nos aseguramos de que todas las condiciones booleanas se cumplan, si se cumplen hacemos los calculos, sino mostramos un mensaje de error
            if (okTotal && okPropina && okPersonas)
            {
                decimal propina = total_cuenta * (porcentaje_propina / 100m);
                decimal total_con_propina = total_cuenta + propina;
                decimal pago_por_persona = total_con_propina / numero_personas;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Propina: {propina:C0}");
                Console.WriteLine($"Total: {total_con_propina:C0}");
                Console.WriteLine($"Cada persona paga: {pago_por_persona:C0}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Error: Por favor ingresa valores numéricos válidos. Recuerda que el número de personas debe ser mayor a 0.");
                Console.ResetColor();
            }
        }
    }
}
