using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class TestPila    {

        static TestPila()
        {

            Disco disco_1 = new Disco();
            disco_1.ValorInt = 1;

            Disco disco_2 = new Disco();
            disco_2.ValorInt = 2;

            Disco disco_3 = new Disco();
            disco_3.ValorInt = 3;

            /*---------------------------------------------*/
            /*  TESTING:
                Creació de pila */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  Creació de pila ");
            Pila pila_A = new Pila();
            Pila pila_B = new Pila();
            Pila pila_C = new Pila();


            int size_A = pila_A.Size;
            bool buida_A = pila_A.isEmpty();

            Console.WriteLine("Tamany de pila_A: " + size_A.ToString());
            Console.WriteLine("Està buida pila_A: " + buida_A.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Checking top de una pila buida (pila_A) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  Checking top de una pila buida (pila_A) ");
            Console.WriteLine("top de pila_A buida: " + pila_A.Top.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Pushing en una pila buida un disco (pila_A, disco_3) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  Pushing en una pila buida un disco (pila_A, disco_3) ");
            pila_A.push(disco_3);
            Console.WriteLine("disco en top pila (pila_A es Disco 3): " + pila_A.Top.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Elements en una pila buida (pila_B) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine(" Elements en una pila buida (pila_B) ");
            List<Disco> Elements_B = pila_B.Elementos;

            int Total_B = 0;
            Console.WriteLine("Elements en la pila buida ");
            foreach (Disco Element in Elements_B)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
                Total_B++;
            }
            Console.WriteLine("Total: " + Total_B.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Elements en una pila amb un disco (pila_A) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine(" Elements en una pila amb un disco (pila_A) ");
            List<Disco> Elements_A = pila_A.Elementos;

            int Total_A = 0;
            Console.WriteLine("Elements en la pila ");
            foreach (Disco Element in Elements_A)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
                Total_A++;
            }
            Console.WriteLine("Total: " + Total_A.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Elements en una pila amb varis discos disco (pila_C) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine(" Elements en una pila amb varis discos disco (pila_C) ");
            pila_C.push(disco_3);
            pila_C.push(disco_2);
            pila_C.push(disco_1);

            List<Disco> Elements_C = pila_C.Elementos;

            int Total_C = 0;
            Console.WriteLine("Elements en la pila ");
            foreach (Disco Element in Elements_C)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
                Total_C++;
            }
            Console.WriteLine("Total: " + Total_C.ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Poping de una pila amb sols un disco (pila_A disco_3) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine(" Poping de una pila amb sols un disco (pila_A disco_3) ");
            Console.WriteLine("Disco extret: " + pila_A.pop().ValorInt.ToString());
            Console.WriteLine("La pila queda buida: " + pila_A.isEmpty().ToString());
            Console.WriteLine();

            /*---------------------------------------------*/
            /*  TESTING:
                Poping una pila fins a buidar-la (pila_C) */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine(" Poping una pila fins a buidar-la (pila_C) ");
            Total_C = 0;
            while (!pila_C.isEmpty())
            {
                Console.WriteLine("Disco extret: " + pila_C.pop().ValorInt.ToString());
                Total_C++;
            }
            Console.WriteLine("Total: " + Total_C.ToString());
            Console.WriteLine("La pila queda buida: " + pila_A.isEmpty().ToString());
            Console.WriteLine();

        }
    }
}
