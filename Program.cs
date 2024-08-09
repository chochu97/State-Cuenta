using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch sw = new Switch();

            string resp = "si";

            while(resp == "si")
            {
                Console.WriteLine("Desea presionar la tecla?");
                resp = Console.ReadLine();

                if(resp == "si")
                {
                    sw.Presionar();
                }
                
            }

            Console.ReadKey();
        }
    }
}
