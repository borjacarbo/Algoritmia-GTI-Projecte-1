﻿using System;
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

            /*---------------------------------------------*/
            /*  TESTING:
                iterativo(int n,  Pila ini, Pila fin, Pila aux) amb n = 3 */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  iterativo(int n,  Pila ini, Pila fin, Pila aux) amb n = 3");

            Pila pila_C = new Pila();
            int passos;

            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila ini");
            foreach (Disco Element in pila_A.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila aux");
            foreach (Disco Element in pila_B.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila fin");
            foreach (Disco Element in pila_C.Elementos)
            { 
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("Abans d'executarXXXXXXXXXXXXXXXXXXXXXXXX");

            passos = hanoi.iterativo(pila_A.Size, ref pila_A, ref pila_C, ref pila_B);

            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila ini");
            foreach (Disco Element in pila_A.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila aux");
            foreach (Disco Element in pila_B.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila fin");
            foreach (Disco Element in pila_C.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("Despprés d'executar XXXXXXXXXXXXXXXXXXXXXXXX");

            Console.WriteLine(" El número de passos calculat per iteració son: "  + passos.ToString() );

            /*---------------------------------------------*/
            /*  TESTING:
                iterativo(int n,  Pila ini, Pila fin, Pila aux) amb n = 4 */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  iterativo(int n,  Pila ini, Pila fin, Pila aux) amb n = 4");


            Pila pila_ini = new Pila();
            Pila pila_fin = new Pila();
            Pila pila_aux = new Pila();


            Disco disco_10 = new Disco();
            disco_10.ValorInt = 1;
            Disco disco_20 = new Disco();
            disco_20.ValorInt = 2;
            Disco disco_30 = new Disco();
            disco_30.ValorInt = 3;
            Disco disco_40 = new Disco();
            disco_40.ValorInt = 4;

            pila_ini.push(disco_40);
            pila_ini.push(disco_30);
            pila_ini.push(disco_20);
            pila_ini.push(disco_10);

            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila ini");
            foreach (Disco Element in pila_ini.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila aux");
            foreach (Disco Element in pila_aux.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila fin");
            foreach (Disco Element in pila_fin.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("Abans d'executarXXXXXXXXXXXXXXXXXXXXXXXX");

            passos = hanoi.iterativo(pila_ini.Size, ref pila_ini, ref pila_fin, ref pila_aux);

            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila ini");
            foreach (Disco Element in pila_ini.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila aux");
            foreach (Disco Element in pila_aux.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("........................ ");
            Console.WriteLine("Elements en la pila fin");
            foreach (Disco Element in pila_fin.Elementos)
            {
                Console.WriteLine(" " + Element.ValorInt.ToString());
            }
            Console.WriteLine("Despprés d'executar XXXXXXXXXXXXXXXXXXXXXXXX");

            Console.WriteLine(" El número de passos calculat per iteració son: " + passos.ToString());

        }
    }
}

