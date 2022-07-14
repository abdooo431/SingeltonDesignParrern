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
        private static Singelton instance = null;
        private static readonly object o = new object();
        public static Singelton GetInstans
        {
            get
            {
                if (instance is null)
                {
                    lock (o)
                    {
                        if (instance == null)
                        {
                            instance = new Singelton();
                        }
                    }
                }


                return instance;
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
