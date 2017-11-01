using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        public static string pre1 = "";
        public static string pre2 = "";
        public static string vol1 = "";
        public static string vol2 = "";
        public static decimal dpre1 = 0;
        public static decimal dpre2 = 0;
        public static decimal dvol1 = 0;
        public static decimal dvol2 = 0;
        public static decimal tempDec = 0;
        public static string stringIn = "";
        static void Main(string[] args)
        {
            Program Func = new Program();
            Console.WriteLine("What is p1 - set Unknown as 0");
            dpre1 = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is p2 - set Unknown as 0");
            dpre2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is v1 - set Unknown as 0");
            dvol1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("What is v2 - set Unknown as 0");
            dvol2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(dpre1);
            Console.WriteLine(dpre2);
            Console.WriteLine(dvol1);
            Console.WriteLine(dvol2);
            Console.Write("What is missing V2 or P2");
            stringIn = Console.ReadLine(); 
            if (stringIn == "")
            {
                Func.errNoNum();
            }

            else if (stringIn.ToUpper() == "V2")
            {
                pressureMissV2(dpre1,dpre2, dvol1);
                Console.WriteLine(tempDec);
            }
            else if (stringIn.ToUpper() == "V1")
            {
                pressureMissV2(dpre1, dpre2, dvol2);
                Console.WriteLine(tempDec);
            }
            else
            {
                Func.errIncNum();
            }
            Console.ReadLine();
        }
        
        static void pressureMissV2(decimal p1, decimal p2, decimal v1)
        {
            Program Func = new Program();
            tempDec = p2 / p1;
            tempDec = tempDec * v1;
        }
        static void pressureMissP2(decimal p1, decimal V2, decimal v1)
        {
            Program Func = new Program();
            tempDec = v1 / p1;
            tempDec = tempDec * V2;
        }
        public void errIncNum()
        {
            Console.WriteLine("Error - Incorrect Number Entered Try Again!");
        }
        public void errNoNum()
        {
            Console.WriteLine("Error - No Number Entered Try Again!");
        }
    }
}
