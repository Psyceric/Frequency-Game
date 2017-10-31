using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Program Func = new Program();
            Func.startMenu();

        }
        public void startMenu()
        {
            Program Func = new Program();
            Console.Clear();
            centText("\n\n\n\n\n");
            centText("Welcome to Frequency");
            centText("'Prepare to be beat'");
            centText("Type Credits for Information");
            centText("-------------------------");
            centText("Press Enter to Start Game");
            Console.ReadLine();
            Console.Clear();
        }
        static void centText(string arg)
        {
            Program Func = new Program();
            int xOffset = Console.WindowWidth / 2 + arg.Length / 2;
            Console.WriteLine(arg.PadLeft(xOffset));
        }


    }
}

