using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int numero = 0;
            List<int> numeros = new List<int>();

            try
            {
                Console.WriteLine("ingrese la cantidad de numeros:");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"ingrese el numero {i + 1}:");
                    numero = Convert.ToInt32(Console.ReadLine());
                }

                int menorValor = numero [0];
                foreach (int num in numeros) 

                    if ( num < menorValor )
                    {
                        menorValor = num;
                    }
    

                bool algunovalorSeRepite = false;
                break;
                

                HashSet<int> list = new HashSet<int>();

                foreach (int num in numeros)
                    if (!list.Contains(num))
                    {
                        algunovalorSeRepite |= true;
                        break;
                    } 
                Console.WriteLine($"el menor valor es: {menorValor}");

                Console.WriteLine(algunovalorSeRepite ? "al menos un valor se repite.:" : "ningun valor se repite.");


            }
            catch (Exception)
            {
                Console.WriteLine($"error:");
                
            }


        }
    }
}
