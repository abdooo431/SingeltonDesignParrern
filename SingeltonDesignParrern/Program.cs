using System;

namespace SingeltonDesignParrern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Singelton oSingeltonEmployee = Singelton.GetInstans;
            oSingeltonEmployee.PrintDetails("Employee Details");

            Singelton oSingeltonStudent = Singelton.GetInstans;
            oSingeltonStudent.PrintDetails("Student Details");

            Console.ReadLine();
        }
    }
}
