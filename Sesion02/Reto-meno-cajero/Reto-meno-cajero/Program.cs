using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_meno_cajero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo_inicial = 500000;
            string pin = "1234";

            
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine("Digite el pin: \n \n");
                string entrada = Console.ReadLine().Trim();

                if (entrada == pin)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ACCESO CONCEDIDO \n \n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("CAJERO AUTOMATICO: \n 1- Consultar \n 2- Depositar \n 3- Retirar \n 4- Salir \n \n");
                    Console.ResetColor();

                    int opcion;
                    int movimientos = 0;
                    do
                    {
                        Console.WriteLine("Digita una opción: \n \n");
                    } while (!int.TryParse(Console.ReadLine(), out opcion));

                    
                    while (opcion != 4)
                    {
                        switch (opcion)
                        {

                            case 1:
                                Console.WriteLine($"Su saldo es: ${saldo_inicial} \n \n");
                                break;

                            case 2:
                                double deposito;
                                do
                                {
                                    Console.WriteLine("Cuanto desea depositar: \n \n");


                                } while (!double.TryParse(Console.ReadLine(), out deposito));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su saldo anterior era de: ${saldo_inicial} \n Ahora es de: ${saldo_inicial += deposito} \n \n");
                                Console.ResetColor();
                                movimientos += 1;
                                break;

                            case 3:
                                double retiro;
                                do
                                {
                                    Console.WriteLine("Cuanto desea retirar: \n \n");
                                } while (!double.TryParse(Console.ReadLine(), out retiro));

                                if (retiro > saldo_inicial)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Saldo insuficiente \n \n ");
                                    Console.ResetColor();
                                }

                                else if (retiro % 10000 != 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Solo se pueden retiros de multiplos de 10 k \n \n");
                                    Console.ResetColor();

                                }

                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"¡ Retiro exitoso !, retiraste ${retiro} \n \n Tu saldo ahora es de: ${saldo_inicial -= retiro} \n \n");
                                    Console.ResetColor();
                                }

                                    movimientos += 1;

                                break;

                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("CAJERO AUTOMATICO: \n 1- Consultar \n 2- Depositar \n 3- Retirar \n 4- Salir \n \n");
                        Console.ResetColor();

                        do
                        {
                            Console.WriteLine("Digita una opción: \n \n");
                        } while (!int.TryParse(Console.ReadLine(), out opcion));


                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sesion cerrada \n \n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Tus movimientos totales fueron ({movimientos}) \n \n");
                    Console.ResetColor();



                    break;

                }

                i++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PIN incorrecto \n \n");
                Console.ResetColor();

            }
            if (i > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cuenta bloqueada \n \n");
                Console.ResetColor();
            }


        }
    }
}
