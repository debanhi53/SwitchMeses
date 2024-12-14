using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMeses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número y te dire en que mes estamos");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 12)
            {
                switch (result)
                {

                    case 1:
                        Console.WriteLine("Estamos en Enero");
                        break;
                    case 2:
                        Console.WriteLine("Estamos en Febrero");
                        break;
                    case 3:
                        Console.WriteLine("Estamos en Marzo");
                        break;
                    case 4:
                        Console.WriteLine("Estamos en Abril");
                        break;
                    case 5:
                        Console.WriteLine("Estamos en Mayo");
                        break;
                    case 6:
                        Console.WriteLine("Estamos en Junio");
                        break;
                    case 7:
                        Console.WriteLine("Estamos en Julio");
                        break;
                    case 8:
                        Console.WriteLine("Estamos en Agosto");
                        break;
                    case 9:
                        Console.WriteLine("Estamos en Septiembre");
                        break;
                    case 10:
                        Console.WriteLine("Estamos en Octubre");
                        break;
                    case 11:
                        Console.WriteLine("Estamos en Noviembre");
                        break;
                    case 12:
                        Console.WriteLine("Estamos en Diciembre");
                        break;

                    default:
                        Console.WriteLine("Tun 0-0");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Dato Incorrecto");
            }
        }
    }
}
