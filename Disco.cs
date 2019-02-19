/*==============================================================
Al hora de decidir-me pel tipus d'implementació de la classe Disco
Escollim la de utilitzar els valors Integer.
MOTIU: sembla més senzill
================================================================ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
     // NotFiniteNumberException de discs
        public int n = 3; // número màxim de discs 

        // TODO: Decidir tipo de Valor -> result per Int
        private int valorInt = 0;


        public int ValorInt
        {
            get
            {
                return valorInt;
            }
            set
            {
                if ((value > 0) && (value <= n))
                {
                    valorInt = value;
                }
            }
        }
    }
}
