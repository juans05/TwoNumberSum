using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int numeroSumar = 0;
            do
            {
                try
                {
                    Console.Write("¿Cuántos nunmeros vas a introducir? ");
                    num = UInt16.Parse(Console.ReadLine());
                }
                catch
                {
                    if (num==0)
                    {
                        Console.Write("¿Cuántos nunmeros vas a introducir? ");
                        num = UInt16.Parse(Console.ReadLine());
                    }
                }

            }
            while (num == 0);
            string[] numerosRegistrados = new string[num]; // Declaración e instanciación del array
            for (int i = 0; i < num; i++)
            {
                Console.Write("Escribe el nombre para elemento {0}: ", i);
                numerosRegistrados[i] = Console.ReadLine();
            }
          
            try
            {
                 Console.Write("¿Ingrese el numero a sumar? ");
                 numeroSumar = UInt16.Parse(Console.ReadLine());
            }
            catch
            {
                if (numeroSumar == 0)
                {
                    Console.Write("¿Ingrese el numero a sumar? ");
                    num = UInt16.Parse(Console.ReadLine());
                }
            }
            // Console.WriteLine("Introducidos los {0} nombres", num);
            Console.WriteLine("Pulsa INTRO para listarlos");
            string a = Console.ReadLine();
            List<string> enteros = new List<string>();
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (Convert.ToInt32(Convert.ToInt32(numerosRegistrados[i]) + Convert.ToInt32(numerosRegistrados[j])) == numeroSumar)
                    {
                        if (Convert.ToInt32(numerosRegistrados[i]) != Convert.ToInt32(numerosRegistrados[j]))
                        {
                            enteros.Add(numerosRegistrados[i]);
                            enteros.Add(numerosRegistrados[j]);
                            break;
                        }
                        break;
                    }
                    
                }
               
            }
            if (enteros.Count() > 0)
            {
                Console.WriteLine("Elemento [{0},{1}]", enteros[0], enteros[1]);
            }
            else {
                Console.WriteLine("Elemento [{0},{1}]","","");
            }
           
            a = Console.ReadLine();
        }
    }
}
