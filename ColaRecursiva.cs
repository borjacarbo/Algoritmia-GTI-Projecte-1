using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    public class ColaRecursiva
    {
        public ColaRecursiva(int n)
        {
            Hanoi hanoi = new Hanoi();

            Pila ini = new Pila();
            Pila fin = new Pila();
            Pila aux = new Pila();

            for (int i = n; i != 0; i--)
            {
                Disco disco = new Disco();
                disco.ValorInt = i;
                ini.push(disco);
            }

            Console.Write("Discos en pila ini: ");
            foreach (Disco Elemento in ini.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }
            Console.WriteLine("");

            Console.Write("Discos en pila fin: ");
            foreach (Disco Elemento in fin.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }
            Console.WriteLine("");

            Console.Write("Discos en pila aux: ");
            foreach (Disco Elemento in aux.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }
            Console.WriteLine("");

            int movimientos = hanoi.colaRecursiva(n, ref ini, ref fin, ref aux);

            Console.WriteLine("");
            Console.WriteLine("Despues del cálculo las pilas quedan como:");
            Console.WriteLine("");

            Console.Write("Discos en pila ini: ");
            foreach (Disco Elemento in ini.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }
            Console.WriteLine("");

            Console.Write("Discos en pila fin: ");
            foreach (Disco Elemento in fin.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }
            Console.WriteLine("");

            Console.Write("Discos en pila aux: ");
            foreach (Disco Elemento in aux.Elementos)
            {
                Console.Write(Elemento.ValorInt.ToString() + "; ");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Utilizando recursividad por cola sale que la solución esta");
            Console.WriteLine("Realizado con " + movimientos.ToString() + " movimientos.");
    
        }
    }
}

