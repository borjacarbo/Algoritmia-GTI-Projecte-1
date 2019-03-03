using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // new TestDisco();
            // new TestPila();
            // new TestHanoi();



            Console.WriteLine("Press 'i' for the Interactive calculation");
            Console.WriteLine("Press 'r' for the Recursive calculation");
            Console.WriteLine("Press 'c' for the Tail recursive calculation");

            string keyString = Console.ReadLine();

            while (!(keyString.Equals("i") || keyString.Equals("r") || keyString.Equals("c")))
            {

                Console.WriteLine(" No has seleccionado la opción correcta");
                Console.WriteLine("");

                Console.WriteLine("Pulsa 'i' para el cálculo Interactivo");
                Console.WriteLine("Pulsa 'r' para el cálculo Recursivo");
                Console.WriteLine("Pulsa 'c' para el cálculo Recursivo por Cola");

                keyString = Console.ReadLine();

            }


            Console.WriteLine(" Introduce un número del 1 al 100, ambos inclusives");
            Console.WriteLine("");

            String keyInt = Console.ReadLine(); ;


            while ((Int32.Parse(keyInt) < 0) || (Int32.Parse(keyInt) > 100)) 
            {

                Console.WriteLine(" No has seleccionado la opción correcta");
                Console.WriteLine("");

                Console.WriteLine(" Introduce un número del 1 al 100, ambos inclusives");
                Console.WriteLine("");

                keyInt = Console.ReadLine();

            }

            switch (keyString)
                 {
                case "i":
                    Iterativo iterativo = new Iterativo(Int32.Parse(keyInt));
                    break;
                case "r":
                    Recursivo recursivo = new Recursivo(Int32.Parse(keyInt));
                    break;
                case "c":
                    ColaRecursiva colaRecursiva = new ColaRecursiva(Int32.Parse(keyInt));
                    break;
            }

         

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

    }
}