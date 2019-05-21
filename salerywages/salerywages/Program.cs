using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salerywages
{//Stacey smyth's app studying programing test 2 ///
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my employee data base");
            Console.WriteLine("Your salary is set at $80,000 per year.");
            Console.WriteLine("Your salary per week is $1538.46.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********i will calculate how many hours of work you did******");
            Console.WriteLine("Enter the number of hours worked this week: ");
            Console.WriteLine("Your wages per week is: ");
            Console.ReadLine();
        }
        private string annualsalary = Console.ReadLine();
        private string weeklysalary = Console.ReadLine();

    }

    class Salary
    {
        ///attributes///

        string sal;
        string perweek;
        double eighty;

        public string Sal { get { return Sal; } set { sal = value; } }
        public string Perweek { get { return perweek; } set { perweek = value; } }
        double Eighty { get { return eighty; } set { eighty = value; } }
        private string annualsalary = Console.ReadLine();
        private string weeklysalary = Console.ReadLine();
    }

        /// constructor///


        //public Salary(string sal, string perweek, double eighty)
        //{
             ///Sal = sal;
             //Perweek = perweek;
             //Eighty = eighty;///

        //}

        public Salary(string annualsalary, string weeklysalary)
    {
        Console.Write($"Your salary is $80,000 per year.")
    }
        static double ansalary(double ansalary / double weeklysalary)
    {
        return Math(ansalary / weeklysalary) 
    }

    class Wages
    {
        Console.WriteLine("your ");
        double hourlyRate = double.Parse(Console.ReadLine());
        double numHours = double.Parse(Console.ReadLine());
        int weeklyWages = int.Parse(Console.ReadLine());
    }

         public Wages
          {
        public string numHours { get { return numHours; } set { numhours = value; } }
    public string hourRate { get { return hourlyRate; } set { hourlyrate = value; } }
    Console.Write($"********i will calculate how many hours of work you did******");
        Console.WriteLine("Enter the number of hours worked this week: ");
            Console.WriteLine("Your wages per week is: ");
          }


        
}
