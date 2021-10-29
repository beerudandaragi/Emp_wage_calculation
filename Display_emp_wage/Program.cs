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
            int Is_Part_Time = 1;
            int IS_FULLTIME = 2;
            int EMP_RATE_PER_HOURS = 80;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == Is_Part_Time)
            {
                emphrs = 4;
            }
            else if (empcheck == IS_FULLTIME)
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
