using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class TestHanoi
    {
        static TestHanoi()
        {
            Hanoi hanoi = new Hanoi();

            /*---------------------------------------------*/
            /*  TESTING:
                de pila_A (plena) a Pila_B (buida) 
                amb move_disco(pila_A, pila_B ) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  de pila_A (plena) a Pila_B (buida) amb move_disco(pila_A, pila_B )");

            Pila pila_A = new Pila();
            Pila pila_B = new Pila();

            Disco disco_1 = new Disco();
            disco_1.ValorInt = 1;
            Disco disco_2 = new Disco();
            disco_2.ValorInt = 2;
            Disco disco_3 = new Disco();
            disco_3.ValorInt = 3;

            pila_A.push(disco_3);
            pila_A.push(disco_2);
            pila_A.push(disco_1);

            int loop = pila_A.Size;

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("");
                Console.Write("Abans de menejar   ");
                Console.Write(" Top Pila_A: " + pila_A.Top.ToString());
                Console.WriteLine(" Top Pila_B: " + pila_B.Top.ToString());
                foreach (Disco element in pila_A.Elementos) Console.WriteLine(" En Pila A " + element.ValorInt.ToString());
                Console.WriteLine("...........");
                foreach (Disco element in pila_B.Elementos) Console.WriteLine(" En Pila B " + element.ValorInt.ToString());
                hanoi.mover_disco(ref pila_A, ref pila_B);
                Console.Write("Despres de menejar ");
                Console.Write(" Top Pila_A: " + pila_A.Top.ToString());
                Console.WriteLine(" Top Pila_B: " + pila_B.Top.ToString());
                foreach (Disco element in pila_A.Elementos) Console.WriteLine(" En Pila A " + element.ValorInt.ToString());
                Console.WriteLine("...........");
                foreach (Disco element in pila_B.Elementos) Console.WriteLine(" En Pila B " + element.ValorInt.ToString());
                Console.WriteLine("Següent iteració");

            }
            Console.WriteLine();





            /*---------------------------------------------*/
            /*  TESTING:
                de pila_A (plena) a Pila_B (buida) 
                amb move_disco(pila_B, pila_A ) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  de pila_A (plena) a Pila_B (buida) amb move_disco(pila_B, pila_A )");
                   
            Pila pila_C = new Pila();
    

            for (int i = 0; i<loop; i++)
            {
                Console.WriteLine("");
                Console.Write("Abans de menejar   ");
                Console.Write(" Top Pila_A: " + pila_A.Top.ToString());
                Console.WriteLine(" Top Pila_B: " + pila_B.Top.ToString());
                foreach (Disco element in pila_A.Elementos) Console.WriteLine(" En Pila A " + element.ValorInt.ToString());
                Console.WriteLine("...........");
                foreach (Disco element in pila_B.Elementos) Console.WriteLine(" En Pila B " + element.ValorInt.ToString());
                hanoi.mover_disco(ref pila_B, ref pila_A);
                Console.Write("Despres de menejar ");
                Console.Write(" Top Pila_A: " + pila_A.Top.ToString());
                Console.WriteLine(" Top Pila_B: " + pila_B.Top.ToString());
                foreach (Disco element in pila_A.Elementos) Console.WriteLine(" En Pila A " + element.ValorInt.ToString());
                Console.WriteLine("...........");
                foreach (Disco element in pila_B.Elementos) Console.WriteLine(" En Pila B " + element.ValorInt.ToString());
                Console.WriteLine("Següent iteració");

            }
            Console.WriteLine();
        }
    }
}

