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
            int IS_FULLTIME = 1;
            int EMP_RATE_PER_HOURS = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULLTIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOURS;
            Console.WriteLine("Emp Wage:" + empwage);
            Console.ReadKey();
        }
    }
}
