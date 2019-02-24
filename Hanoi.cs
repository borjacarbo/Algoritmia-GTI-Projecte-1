using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(ref Pila a, ref Pila b)
        {
            if ((b.Top == 0) || (a.Top == 0))
            {

                if (b.Top == 0)
                {
                    Disco disco = a.pop();
                    b.push(disco);
                }
                else
                {
                    Disco disco = b.pop();
                    a.push(disco);
                }
            }
            else
            {
                if (a.Top > b.Top)
                {
                    Disco disco = b.pop();
                    a.push(disco);
                }
                else
                {
                    Disco disco = a.pop();
                    b.push(disco);
                }
            }
        }

        public int iterativo(int delimitador, ref Pila ini, ref Pila fin, ref Pila aux)
        {
            int contador = 0;

            if ((delimitador % 2) == 0) 
                // cas Par
            {
                while (fin.Size < delimitador)
                {
                    this.mover_disco(ref ini, ref aux);
                        contador++;
                    if (fin.Size < delimitador)
                    {
                        this.mover_disco(ref ini, ref fin);
                        contador++;
                    }
                    if (fin.Size < delimitador)
                    {
                        this.mover_disco(ref aux, ref fin);
                        contador++;
                    }
                }
            }
            else  // cas impar
            {
                while (fin.Size < delimitador)
                {
                    this.mover_disco(ref ini, ref fin);
                    contador++;
                    if (fin.Size < delimitador)
                    {
                        this.mover_disco(ref ini, ref aux);
                        contador++;
                        this.mover_disco(ref aux, ref fin);
                        contador++;
                    }
                }
            }
            return contador;
        }
    }
}
