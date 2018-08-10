using System;

namespace CG_5_3_Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Beat the Computer! First to 20 wins!");
            Console.WriteLine(); //blank line between game name and first user entry line for readability
            Console.Write("Player 1 name: ");
            string player1 = Console.ReadLine();
            string player2 = "Computer";
            Console.WriteLine(); //blank line
            Console.WriteLine("{0}  vs  {1}", player1, player2);
            Console.WriteLine();


            //declare variables for totals as integers
            int rollTotal1 = 0;
            int rollTotal2 = 0;


            do
            {
                //ask user to hit enter to roll, readline so it pauses until user hits enter
                //create variable for first roll set it equal to random roll from method and print to console
                
                Console.Write("{0} hit enter to roll.", player1);
                Console.ReadLine();
                int firstrollP1 = RollDice();
                Console.WriteLine(firstrollP1);

                //set roll total variable for user, total plus random method-generated number for each turn
                rollTotal1 = rollTotal1 + firstrollP1;

                //print user total to console
                Console.Write("Current total for {0} is {1} \n", player1, rollTotal1);
                // \n added a line break so declaration of totals would print on separate lines instead of the same line

                //ask user to hit enter to make computer's roll, console.readline so it pauses until user hits enter
                //set first roll variable to equal random return from method and then print to console

                Console.Write("Hit enter for {0} to roll.", player2);
                Console.ReadLine();
                int firstrollP2 = RollDice();
                Console.WriteLine(firstrollP2);

                //set roll total variable for computer, total plus random number roll from each turn
                rollTotal2 = rollTotal2 + firstrollP2;

                //print computer total to console
                Console.Write("Current total for {0} is {1} \n", player2, rollTotal2);
                Console.WriteLine(); //added for extra space


            } while (rollTotal1 < 20 && rollTotal2 < 20);
            //while statement so loop will repeat until player 1 or the computer's total is 20 or more


            //create code that determines winner, winner is player1 unless player 2's total is greater than player 1's, then winner is player 1
            string winner = player1;
            if (rollTotal2 > rollTotal1)
                winner = player2;

            //print winner to console
            Console.WriteLine("Winner is {0}!", winner);
            Console.ReadLine();
            

        }

        /// <summary>
        /// randomized roll for two six-sided dice
        /// </summary>
        /// <returns>randomized roll for two six-sided dice added together</returns>
        /// https://stackoverflow.com/questions/3975290/produce-a-random-number-in-a-range-using-c-sharp
        private static int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(2, 13);

            //wanted a roll of 2 dice added together so did min 2 and max 13 since min is inclusive and max is exclusive
            //originally had the code on return line as two lines of code (shown below in comment), 
            //didn't actually need to name the variable, so i consolidated into one.
            //int dicePair = rnd.Next(2, 13);
            //return dicePair;
        }








    }
}
