using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignParrern
{
    public class Singelton
    {
        private static int counter = 0;
        public Singelton()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
