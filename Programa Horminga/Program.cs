using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Horminga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string and = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..t";

            int deadand = CountDeadAnd(and);

            Console.WriteLine($"El numero de hormiga muerta es de: {deadand}");
            Console.ReadLine();
        }

        static int CountDeadAnd(string and)
        {
            int deadand = 0;
            int i = 0;

            while (i < and.Length) 
            {
                if (i <= and.Length - 3 && (and.Substring(i, 3) == "ant"  || and.Substring(i, 3) == "nat"))
                {
                    deadand++;
                    i+= 3;
                }
                else
                {
                    i++;
                }
            }

            return deadand;
        }
    }
}
