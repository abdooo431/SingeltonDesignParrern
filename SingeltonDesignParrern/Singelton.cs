using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignParrern
{
    public sealed class Singelton
    {
        private static readonly Lazy<Singelton> instance = new Lazy<Singelton>(()=>new Singelton());
        public static Singelton GetInstans
        {
            get
            {
                return instance.Value;
            }
        }
        private Singelton()
        {
        }
    public void PrintDetails(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
