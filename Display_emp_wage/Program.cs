using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_emp_wage
{
   public class EmpWageBuilderObject
    {
        public const int Is_Part_Time = 1;
        public const int IS_FULLTIME = 2;
        private string Company;

        private int EMP_RATE_PER_HOURS = 80;
        private int Num_Of_Working_days = 10;
        private int Max_Hrs_In_Month = 30;
        private int totalempwage;

        public  EmpWageBuilderObject(string Company, int EMP_RATE_PER_HOURS, int Num_Of_Working_days, int Max_Hrs_In_Month)
        {
            this.Company=Company;
            this.EMP_RATE_PER_HOURS=EMP_RATE_PER_HOURS;
            this.Num_Of_Working_days=Num_Of_Working_days;
            this.Max_Hrs_In_Month=Max_Hrs_In_Month;
    }
        public void ComputeEmpWage()
        {


            int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
            while (totalemphrs <= Max_Hrs_In_Month && totalworkingdays < Num_Of_Working_days)
            {
                totalworkingdays++;
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
                totalemphrs += emphrs;
                Console.WriteLine("Days:" + totalworkingdays + "Emphrs:" + emphrs);
            }
            int totalempwage = totalemphrs *this. EMP_RATE_PER_HOURS;
            Console.WriteLine("Total Emp Wage For company:"+Company  + "Is " + totalempwage);
            Console.ReadLine();
        }
        public string Tostring()
        {
            return "Total Emp Wage For company:" + this.Company + "Is " + this.totalempwage; 
        }
        static void Main(string[] args)

        {

            EmpWageBuilderObject HCL = new EmpWageBuilderObject("HCL", 100, 12, 30);
            EmpWageBuilderObject Tata = new EmpWageBuilderObject("Tata", 120, 20, 40);
            HCL.ComputeEmpWage();
            Console.WriteLine(HCL.ToString());
            Tata.ComputeEmpWage();
            Console.WriteLine(Tata.ToString());

        }
        

  
    }

}