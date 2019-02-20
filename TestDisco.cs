using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class TestDisco
    {
        static TestDisco()
        {

            /*---------------------------------------------*/
            /*  TESTING:
                Creació de discos */
            /*---------------------------------------------*/
            Console.WriteLine(" =================================================================================================");
            Console.WriteLine("  Creació de discos ");
            Disco disco_1 = new Disco();
            disco_1.ValorInt = 1;
            int Valor_1 = disco_1.ValorInt;

            Disco disco_2 = new Disco();
            disco_2.ValorInt = 2;
            int Valor_2 = disco_2.ValorInt;

            Disco disco_3 = new Disco();
            disco_3.ValorInt = 3;
            int Valor_3 = disco_3.ValorInt;

            Console.WriteLine("Disco 1 Creat amb valor: " + Valor_1.ToString());
            Console.WriteLine("Disco 2 Creat amb valor: " + Valor_2.ToString());
            Console.WriteLine("Disco 3 Creat amb valor: " + Valor_3.ToString());
            Console.WriteLine();

        }
    }
}
