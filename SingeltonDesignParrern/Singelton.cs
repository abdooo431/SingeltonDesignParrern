using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignParrern
{
    public sealed class Singelton
    {
        private static int counter = 0;
        private static readonly Lazy<Singelton> instance = new Lazy<Singelton>(()=>new Singelton());
        private static readonly object o = new object();
        public static Singelton GetInstans
        {
            get
            {
                return instance.Value;
            }
        }
        private Singelton()
        {
            counter++;
            Console.WriteLine("counter Value = " + counter);
        }
        public void PrintDetails(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
