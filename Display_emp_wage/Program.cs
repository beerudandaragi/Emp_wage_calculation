using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_emp_wage
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HOURS = 80;
        public const int Num_Of_Working_days = 10;



        static void Main(string[] args)
        {


            int emphrs = 0;
            int empwage = 0;
            int totalempwage = 0;
            for (int day = 0; day < Num_Of_Working_days; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Is_Part_Time:
                        emphrs = 4;
                        break;
                    case IS_FULLTIME:
                        emphrs = 8;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }

                empwage = emphrs * EMP_RATE_PER_HOURS;
                totalempwage += empwage;
                Console.WriteLine("Emp Wage:" + empwage);
            }
            Console.WriteLine("Total Emp Wage:" + totalempwage);
            Console.ReadKey();
        }
    }
}
