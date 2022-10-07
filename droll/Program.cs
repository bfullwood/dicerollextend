namespace Dice_Lab
{
    internal class Program
    {
        static void Main(string[] args, bool askToContinue)
        {
            bool  goOn = true;
            while (goOn == true)
            {
                int input;
                
                {
                    Console.WriteLine("Welcome to Against all odds Casino");

                    Console.WriteLine("How many sides does for a pair of dice? please enter a number");

                    input = int.Parse(Console.ReadLine());
                }
                
                {
                    Console.WriteLine("You must enter a positive number");
                    continue;
                }
                if ((input >= 1 && input != 6))
                {
                    Console.WriteLine("Okay, let's roll your " + input + "-sided dice");
                    int roll1 = DieRoll(input);
                    int roll2 = DieRoll(input);
                    Console.WriteLine("You rolled a " + roll1 + " and a " + roll2 + " for a total of " + (roll1 + roll2));
                    goOn = AskToContinue();
                    break;
                }
                else
                {
                    Console.WriteLine("The tried and true, " + input + "-sided dice!");
                    int roll1 = DieRoll(input);
                    int roll2 = DieRoll(input);
                    Console.WriteLine("You rolled a " + roll1 + " and a " + roll2 + " for a total of " + (roll1 + roll2));
                    Console.WriteLine(SixDie(roll1, roll2));
                    goOn = AskToContinue();

                }
            }
        }
        //public static string SixDies(int roll1, int roll2);

        public static string SixDie(int roll1, int roll2)
        {
            if (roll1 == 1 && roll1 == roll2)
            {
                return "Snake Eyes!\nCraps.....?";
            }
            else if (roll1 == 6 && roll1 == roll2)
            {
                return "Box Cars!\nCraps....?";
            }
            else if ((roll1 == 1 && roll2 == 2) || (roll1 == 2 && roll2 == 1))
            {
                return "Ace Deuce!\nCraps....?";
            }
            else if ((roll1 + roll2 == 7) || (roll1 + roll2 == 11))
            {
                return "You Win!!!";
            }


            else
            {
                return "I'm sorry, you lose!";
            }
        }
        public static int DieRoll(int sides)
        {
            Random r = new Random();
            int roll = r.Next(1, sides + 1);
            return roll;
        }


        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to order anything else (y/n)?");
            string input = Console.ReadLine().ToLower();
            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't get that. Please try entering (y/n)");
                return AskToContinue();
            }
        }
    }
}
