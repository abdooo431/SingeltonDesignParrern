using System;

namespace SingeltonDesignParrern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Singelton oSingeltonEmployee = new Singelton();
            oSingeltonEmployee.PrintDetails("Employee Details");

            Singelton oSingeltonStudent = new Singelton();
            oSingeltonStudent.PrintDetails("Student Details");

            Console.ReadLine();
        }
    }
}
