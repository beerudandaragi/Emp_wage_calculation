using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_emp_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee  Wage Computation");
            int IS_FULLTIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULLTIME)
            {
                Console.WriteLine("employee is present ");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            Console.ReadKey();
        }
    }
}
