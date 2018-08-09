using System;

namespace CG_5_3_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a dice game to see who can get to 20 first.You will roll 
            //two 6 - sided dice and add up the numbers.  Then the computer gets to 
            //go, and it does the same.  This process will repeat LOOP! until either you or 
            //the computer wins.You should put the rolling of the dice into its own method.  
            //Make sure your methods have XML comments for IntelliSense.
            //1. roll dice
            //  user roll
            //  computer roll
            //repeat = loop!
            // if user or computer >= 20   winner!
            //need counter for running total

            //user total  
            //computer total
            //user roll dice -  if user total >= 20 print Win and stop
            //computer roll dice - if computer total >= 20 Print Computer Wins and stop
            //loop back around if not >=20


            Console.WriteLine("Beat the Computer! First to 20 wins!");
            Console.WriteLine(); //blank line between game name and first user entry line for readability
            Console.Write("Player 1 name: ");
            string player1 = Console.ReadLine();
            string player2 = "Computer";
            Console.Write($"{player1} vs {player2}");





            Console.ReadLine();


        }

        private static int RollDice()
        //{

//roll 2 to 12 at random for two six-sided dice, return number
//   Random diceRoll = new Random();



//}


    /*public double GetRandomNumberInRange(double minNumber, double maxNumber)
    {
    return new Random().NextDouble() * (minNumber - maxNumber) + minNumber;
    }*/







}
}
