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
                if ((b.Top == 0))
                {
                    Disco disco = a.pop();
                    b.push(disco);
                }
                if ((a.Top == 0))
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
                if (a.Top < b.Top)
                {
                    Disco disco = a.pop();
                    b.push(disco);
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
