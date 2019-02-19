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
                int TopDisc = list.Count - 1;
                Disco disco = list.ElementAt(TopDisc);
                return disco.ValorInt;
               }
            set
            {
                Disco disco = new Disco();
                disco.ValorInt = value;
                list.Add(disco);
            }
        }
        public List<Disco> Elementos {
            get
            {
                return list;
            }
            set
            {
                list = value;
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

            if (isEmpty()) return null;
            int TopDisc = list.Count - 1;
            Disco disco = list.ElementAt(TopDisc);
            list.RemoveAt(TopDisc);
            return disco;
        }                

        public bool isEmpty()
        {
             if ( list.Count == 0) return true;
            return false;
        }

    }
}
