using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su usuario: ");
            string user = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("Ingrese su contraseña: ");
            string pass = Console.ReadLine().ToLower().Trim();

            if (user == "admin" && pass == "12345"){
                Console.Write("BIENVENIDO AL SISTEMA");

                Console.WriteLine("Calculadora con switch");

                Console.WriteLine("Digite el valor de A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el valor de B: ");
                float b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite la opción deseada: ");
                Console.Write("1 - Sumar");
                Console.Write("2 - Restar");
                Console.Write("3 - Multiplicar");
                Console.Write("4 - Dividir");

                int opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write($"LA SUMA DE {a} + {b} ES {a + b}");
                        break;

                    case 2:
                        Console.Write($"LA RESTA DE {a} - {b} ES {a - b}");
                        break;

                    case 3:
                        Console.Write($"LA MULTIPLICACIÓN DE {a} X {b} ES {a * b}");
                        break;

                    case 4:

                        if (b == 0)
                            Console.WriteLine("No se puede dividir entre 0");

                        else
                            Console.Write($"LA DIVISIÓN DE {a} / {b} ES {a / b}");

                        break;


                    default:
                        Console.Write("OPCION NO IDENTIFICADA");
                        break;
                }
            }
            else
            {
                Console.Write("CREDENCIALES INCORRECTAS");
            }
            
        }
    }
}
