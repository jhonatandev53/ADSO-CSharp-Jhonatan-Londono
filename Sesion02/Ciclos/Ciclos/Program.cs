using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine($"Valor: {i}");
            //    }

            //    // Ciclo do - while


            //    int edad;
            //    do
            //    {
            //        Console.WriteLine("Digite su edad: ");
            //    } while (!int.TryParse(Console.ReadLine(), out edad) || edad < 1 || edad > 120);

            //    int suma = 0;
            //    for (int i = 1; i < 6; i++)
            //    {
            //        Console.Write($"Puntaje {i}: ");
            //        int.TryParse(Console.ReadLine(), out int puntaje);
            //        suma += puntaje;
            //    }
            //    double promedio = suma / 5.0;
            //    Console.WriteLine($"Promedio: {promedio}");


            //


            double tabla;
            

            do
            {
                Console.WriteLine("QUE TABLA DE MULTIPLICAR DESEA");
            } while (!double.TryParse(Console.ReadLine(), out  tabla));


           
            Console.WriteLine($"TABLA DEL {tabla}");
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine($"{tabla} x {i} = {tabla * i}");
               
            }
        }
    }
}
