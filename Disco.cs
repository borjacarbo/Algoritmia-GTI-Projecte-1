/*=========================================================
Hem decidit utilitzar com a valor per als discos la variant 
  the Int en lloc de la de string.
El disc te un tamany acorde al valor utilitzat.
===========================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {

        public int n = 3; // número màxim de discs 

        // TODO: Decidir tipo de Valor
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
