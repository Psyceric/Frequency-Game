using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Unknown
{
    class Program
    {

        //Program Func = new Program();
        static Random rnd = new Random();
        public static bool hitSuccess = false;
        public static decimal defVal = 1;
        public static decimal acurVal = 1;
        public static decimal strenVal = 1;
        public static decimal healVal = 8 + rnd.Next(1, 5);
        public static decimal maxHeal = 0;
        public static decimal goldVal = 10 + rnd.Next(1, 13);
        public static decimal points = 16;
        public static string userDef = "0";
        public static string userAcur = "0";
        public static string userStren = "0";
        public static string userName = "";
        public static bool pointsTF = false;
        public static bool pointsTFacur = false;
        public static bool pointsTFstren = false;
        public static decimal num;
        public static bool confirm = false;
        public static int useable = 0;
        public static decimal tempHeal = 0;
        public static bool pathOne = false;
        public static bool pathTwo = false;
        public static bool pathThree = false;
        public static string tempString = "";
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Program Func = new Program();
            Func.Start();
            Console.Clear();
            Func.defStat();
            Func.acurStat();
            Func.strenStat();
            Console.Clear();
            Func.statMenu();
            Func.triCrossroad("Cave", "Path", "North");
            if (pathOne == true)
            {
                Func.encounter(1, 1, 1, 1, 1, "Big Boi LLoyd");
            }
        }
        public void Start()
        {
            centText("------------------------------");
            centText("Welcome To Location Unknown  ");
            centText("'Be What you want to be'   ");
            centText("By - Psyceric   ");
            centText("------------------------------");
            centText("\n\n\n");
            centText("Press Enter To Start");
            Console.ReadLine();
        }
        public void defStat()
        {
            Program Func = new Program();
            Func.pointAdd("Defense");
            while (pointsTF == false)
            {
                userDef = Console.ReadLine();
                confirm = decimal.TryParse(userDef, out num);
                if (userDef == "")
                {
                    Func.errNoNum();
                    Func.pointAdd("Defense");
                    pointsTF = false;
                }

                else if (userDef.ToUpper() == "HELP")
                {
                    Func.helpMenu("Defense");
                    pointsTF = false;
                }
                else if ((confirm) == true)
                {
                    if (decimal.Parse(userDef) > points)
                    {
                        Func.errOverNum();
                        Func.pointAdd("Defense");
                        pointsTF = false;
                    }
                    else if (decimal.Parse(userDef) <= points)
                    {
                        Func.remainpts(decimal.Parse(userDef));
                        points = points - decimal.Parse(userDef);
                        defVal = decimal.Parse(userDef) + defVal;
                        pointsTF = true;
                    }
                    else
                    {
                        Func.errIncEnt("Defense");
                        pointsTF = false;
                    }
                }
                else
                {
                    Func.errIncEnt("Defense");
                    Func.pointAdd("Defense");
                    pointsTF = false;
                }
                Func.line30();
                while (pointsTF == false)
                {
                    userDef = Console.ReadLine();
                    confirm = decimal.TryParse(userDef, out num);
                    if (userDef == "")
                    {
                        Func.errNoNum();
                        Func.pointAdd("Defense");
                        pointsTF = false;
                    }
                    else if (userDef.ToUpper() == "HELP")
                    {
                        Func.helpMenu("Defense");
                        Func.pointAdd("Defense");
                        pointsTF = false;
                    }
                    else if ((confirm) == true)
                    {
                        if (decimal.Parse(userDef) > points)
                        {
                            Func.errOverNum();
                            Func.pointAdd("Defense");
                            pointsTF = false;
                        }
                        else if (decimal.Parse(userDef) <= points)
                        {
                            centText("You have added " + userDef + " points to Defense!");
                            Func.remainpts(decimal.Parse(userDef));
                            pointsTF = true;
                        }
                        else
                        {
                            Func.errIncEnt("Defense");
                            pointsTF = false;
                        }
                    }
                    else
                    {
                        Func.errIncEnt("Defense");
                        pointsTF = false;
                    }
                }
            }
        }
        public void acurStat()
        {
            Program Func = new Program();
            Func.pointAdd("Accuracy");
            while (pointsTFacur == false)
            {
                userAcur = Console.ReadLine();
                confirm = decimal.TryParse(userAcur, out num);
                if (userAcur == "")
                {
                    Func.errNoNum();
                    Func.pointAdd("Accuracy");
                    pointsTFacur = false;
                }

                else if (userAcur.ToUpper() == "HELP")
                {
                    Func.helpMenu("Accuracy");
                    pointsTFacur = false;
                }
                else if ((confirm) == true)
                {

                    if (decimal.Parse(userAcur) > points)
                    {
                        Func.errOverNum();
                        Func.pointAdd("Accuracy");
                        pointsTFacur = false;
                    }
                    else if (decimal.Parse(userAcur) <= points)
                    {
                        Func.remainpts(decimal.Parse(userAcur));
                        points = points - decimal.Parse(userAcur);
                        pointsTFacur = true;
                    }
                    else
                    {
                        Func.errIncEnt("Accuracy");
                        Func.pointAdd("Accuracy");
                        pointsTFacur = false;
                    }
                }
                else
                {
                    Func.errIncEnt("Accuracy");
                    Func.pointAdd("Accuracy");
                    pointsTFacur = false;
                }
                Func.line30();
                while (pointsTFacur == false)
                {
                    userAcur = Console.ReadLine();
                    confirm = decimal.TryParse(userAcur, out num);
                    if (userAcur == "")
                    {
                        Func.errNoNum();
                        Func.pointAdd("Accuracy");
                        pointsTFacur = false;
                    }

                    else if (userAcur.ToUpper() == "HELP")
                    {
                        Func.helpMenu("Accuracy");
                        Func.pointAdd("Accuracy");
                        pointsTFacur = false;
                    }
                    else if ((confirm) == true)
                    {

                        if (decimal.Parse(userAcur) > points)
                        {
                            Func.errOverNum();
                            Func.pointAdd("Accuracy");
                            pointsTFacur = false;
                        }
                        else if (decimal.Parse(userAcur) <= points)
                        {
                            Func.remainpts(decimal.Parse(userAcur));
                            pointsTFacur = true;
                        }
                        else
                        {
                            Func.errIncEnt("Accuracy");
                            pointsTFacur = false;
                        }
                    }
                    else
                    {
                        Func.errIncEnt("Accuracy");
                        pointsTFacur = false;
                    }
                }
            }
        }
        public void strenStat()
        {
            Program Func = new Program();
            Func.pointAdd("Strength");
            while (pointsTFstren == false)
            {
                userStren = Console.ReadLine();
                confirm = decimal.TryParse(userStren, out num);
                if (userStren == "")
                {
                    Func.errNoNum();
                    Func.pointAdd("Strength");
                    pointsTFstren = false;
                }

                else if (userStren.ToUpper() == "HELP")
                {
                    Func.helpMenu("Strength");
                    pointsTFstren = false;
                }
                else if ((confirm) == true)
                {

                    if (decimal.Parse(userStren) > points)
                    {
                        Func.errOverNum();
                        Func.pointAdd("Strength");
                        pointsTFstren = false;
                    }
                    else if (decimal.Parse(userStren) <= points)
                    {
                        Func.remainpts(decimal.Parse(userStren));
                        points = points - decimal.Parse(userStren);
                        centText("Your remaining " + points + " Skill points have been added to your Maximum Health");
                        strenVal = decimal.Parse(userStren) + strenVal;
                        pointsTFstren = true;
                    }
                    else
                    {
                        Func.errIncEnt("Strength");
                        Func.pointAdd("Strength");
                        pointsTFstren = false;
                    }
                }
                else
                {
                    Func.errIncEnt("Strength");
                    Func.pointAdd("Strength");
                    pointsTFstren = false;
                }
                Func.line30();
                while (pointsTFstren == false)
                {
                    userStren = Console.ReadLine();
                    confirm = decimal.TryParse(userStren, out num);
                    if (userStren == "")
                    {
                        Func.errNoNum();
                        Func.pointAdd("Strength");
                        pointsTFstren = false;
                    }

                    else if (userStren.ToUpper() == "HELP")
                    {
                        Func.helpMenu("Strength");
                        pointsTFstren = false;
                    }
                    else if ((confirm) == true)
                    {

                        if (decimal.Parse(userStren) > points)
                        {
                            Func.errOverNum();
                            Func.pointAdd("Strength");
                            pointsTFstren = false;
                        }
                        else if (decimal.Parse(userStren) <= points)
                        {

                            //Func.remainpts(decimal.Parse(userStren));
                            points = points - decimal.Parse(userStren);
                            centText("Your remaining " + points + " Skill points have been added to your Maximum Health");
                            strenVal = decimal.Parse(userStren) + strenVal;
                            pointsTFstren = true;
                        }
                        else
                        {
                            Func.errIncEnt("Strength");
                            pointsTFstren = false;
                        }
                    }
                    else
                    {
                        Func.errIncEnt("Strength");
                        pointsTFstren = false;
                    }
                }
                healVal = healVal + points;
                maxHeal = healVal;
                Func.rename();
                acurVal = (acurVal + 75);

            }

        }
        public void errIncEnt(string f)
        {
            Program Func = new Program();
            Func.line30();
            centText("ERROR - You input was incorrectly entered!");

        }
        public void pointAdd(string f)
        {
            Program Func = new Program();
            centText("How many points would you like to add to " + f + "? - Type 'Help' for help....");

        }
        public void helpMenu(string f)
        {
            Console.Clear();
            Program Func = new Program();
            Func.line30();
            centText("Help Menu");
            centText(" You have - " + points + " points  remaining");
            Func.line30();
            centText("Enter in the box below how many points");
            centText("You would like to add to " + f);
            Func.line30();
            centText("[          Made By           ]");
            centText("[        By - Psyceric       ]");
            Func.line30();

        }
        public void errNoNum()
        {
            Program Func = new Program();
            Console.Clear();
            centText("\n\n\n");
            Func.line30();
            centText("You forgot to enter a number!");
        }
        public void errOverNum()
        {
            Program Func = new Program();
            Console.Clear();
            centText("\n\n\n");
            Func.line30();
            centText("The amount entered was more than your amount of points remaining! - You have " + points + " Remaining");
        }
        public void remainpts(decimal f)
        {
            Program Func = new Program();
            centText("You have " + Math.Abs((points - f)) + " Skill Points Remaining");
        }
        public void line30()
        {
            centText("------------------------------");
        }
        public void statMenu()
        {
            Program Func = new Program();
            Console.Clear();
            Func.line30();
            centText("Stats Ratings");
            Func.line30();
            centText("Name          -  " + userName);
            centText("Defense Level -  " + defVal);
            centText("Accuracy %    -  " + acurVal + "%");
            centText("Strength Level-  " + strenVal);
            centText("Max Health    -  " + healVal);
            centText("You Have " + goldVal + " Gold Coins");
            Func.line30();
            centText("\n\n\n");
            // Console.Write("Press Enter to Continue");
            // Console.ReadLine();
        }
        public void rename()
        {
            Program Func = new Program();
            Console.Write("What is your name? - ");
            userName = Console.ReadLine();
        }
        public void Cont()
        {
            Program Func = new Program();
            Func.line30();
            centText("Press Enter To Close Program");
            Console.ReadLine();

        }


        public static bool rlConfirm = false;
        public static string triCross = "";
        public void triCrossroad(String a1, String a2, string a3)
        {
            Program Func = new Program();
            centText("You meet a fork in the road, it splits off into three directions");
            centText("What crossroads do you go down?");
            centText("The three ways are " + a1 + "," + a2 + ", and " + a3);
            triCross = Console.ReadLine();
            while (rlConfirm == false)
            {
                if (triCross.ToUpper() == a1.ToUpper())
                {
                    pathOne = true;
                    rlConfirm = true;
                }

                else if (triCross.ToUpper() == a2.ToUpper())
                {
                    pathTwo = true;
                    rlConfirm = true;
                }
                else if (triCross.ToUpper() == a3.ToUpper())
                {
                    pathThree = true;
                    rlConfirm = true;
                }
                else if (triCross.ToUpper() == "HELP")
                {
                    Func.line30();
                    centText("The three ways are " + a1 + "," + a2 + ", and " + a3);
                    Func.line30();
                    rlConfirm = false;
                }
                else
                {
                    Func.line30();
                    centText("The three ways are " + a1 + "," + a2 + ", and " + a3);
                    Func.line30();
                    rlConfirm = false;
                }

            }
        }

        public void encounter(decimal def, decimal accur, decimal stren, decimal health, decimal maxHealM, string monsterName)
        {
            Program Func = new Program();
            // tempHeal = 20;
            Console.Clear();
            centText("By God! You have encountered an angry " + monsterName);
            centText("What do you do? - Run - or - Fight -");
            tempString = Console.ReadLine().ToUpper();
            if (tempString == "RUN")
            {
                if (rnd.Next(1, 7) == 1)
                {
                    centText("You successfully run from the " + monsterName);

                }
                else
                {
                    tempHeal = rnd.Next(1, 2);
                    centText("You fail at running from the " + monsterName);
                    centText("You loss " + tempHeal + " health");
                    healVal -= tempHeal;
                    centText("You now have " + healVal + " Health");
                    if (healVal < 0)
                    {
                        Func.death(monsterName);
                    }
                }

            }
            else if (tempString == "FIGHT")
            {
                Func.fight(defVal, strenVal, acurVal, maxHeal, healVal, userName, def, accur, stren, maxHealM, health, monsterName);
            }
            //Func.line30();

            Console.ReadLine();
        }
        public static int tmpStren = 0;
        public static int p1tmpdmg = 0;
        public void fight(decimal p1Def, decimal p1stren, decimal p1Acur, decimal p1MaxHeal, decimal p1heal, string p1Name, decimal p2Def, decimal p2stren, decimal p2Acur, decimal p2MaxHeal, decimal p2heal, string p2name)
        {
            Program Func = new Program();
            Random rnd = new Random();

            if (rnd.Next(1, 100) < p1Acur)
            {
                hitSuccess = true;
                tmpStren = Convert.ToInt32(p1stren);
                p1tmpdmg = rnd.Next(1, tmpStren);
                if (p1tmpdmg > 0)
                {
                    p2heal -= p1tmpdmg;
                    Func.healTst(Convert.ToInt32(p1heal), Convert.ToInt32(p2heal), p2name);
                }
                else
                {
                    Func.errMath();
                }
                centText(p1Name + " Successfully landed a hit on " + p2name);
            }
            else
            {
                hitSuccess = false;
                centText(p1Name + " Missed his attack on " + p2name);
            }



        }
        public void healTst(int p2heal, int p1heal, string monsterName)
        {
            Program Func = new Program();
            if (p2heal <= 0)
            {
                Func.death(monsterName);
            }

        }
        public void errMath()
        {
            Program Func = new Program();
            centText("Math Error Occured (our bot needs a teacher, we'll pay ya). Please reload program");
        }
        public void death(string monsterName)
        {

            Program Func = new Program();
            Console.Clear();
            centText("\n\n\n\n\n");
            centText("You Died");
            centText("By A " + monsterName);
            centText("\n\n\n\n\n");
            centText("Press Enter To Play Again \n\n\n\n\n");
            Console.ReadLine();

        }
        public void centText(string str)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.CursorTop);
            Console.WriteLine(str);
        }



    }
}