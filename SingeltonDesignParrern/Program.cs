using System;
using System.Threading.Tasks;

namespace SingeltonDesignParrern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>PrintEmployeeDetails(),
                ()=>PrintStudentDetails()
                );
            

                 
           
            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            Singelton oSingeltonStudent = Singelton.GetInstans;
            oSingeltonStudent.PrintDetails("Student Details");

        }

        private static void PrintEmployeeDetails()
        {
            Singelton oSingeltonEmployee = Singelton.GetInstans;
            oSingeltonEmployee.PrintDetails("Employee Details");
        }
    }
}
