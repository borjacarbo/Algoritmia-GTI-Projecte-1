/*=========================================================
Tipus de Top elegit llista
===========================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        private List<Disco> list;

        public int Size
        {
            get
            {
                return list.Count;
            }
            set
            {
            }
        }
        public int Top {
            get
            {
                if (list.Count == 0) return 0;
                int TopDisc = list.Count - 1;
                Disco disco = list.ElementAt(TopDisc);
                return disco.ValorInt;
               }
            set
            {
            }
        }
        public List<Disco> Elementos {
            get
            {
                return list;
            }
            set
            {
            }
        }
        

        /* TODO: Implementar métodos */
        public Pila()
        {
            list = new List<Disco>();
        }

        public void push(Disco d)
        {
            Disco disco = new Disco();
            list.Add(d);
        }

        public Disco pop()
        {
            Disco disco;
            if (isEmpty())
            {
                disco = new Disco();
                disco.ValorInt = 0;
            }
            else
            { 
            int TopDisc = list.Count - 1;
            disco = list.ElementAt(TopDisc);
            list.RemoveAt(TopDisc);
            }
            return disco;
        }                

        public bool isEmpty()
        {
             if ( list.Count == 0) return true;
            return false;
        }

    }
}
