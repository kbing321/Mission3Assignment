using System;

namespace Mission3Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this game of Tic Tac Toe!");
            Console.WriteLine("Please enter Player1's Name:");
            string Player1 = Console.ReadLine();
            Console.WriteLine("Please enter Player2's Name:");
            string Player2 = Console.ReadLine();

            string[] PlayerChoice = new string[9];

            // method to display the board

            // maybe use a random number between 1 and 2 to choose which player goes first
            int whoGoesFirst = 0;
            Random randNum = new Random();
            whoGoesFirst = randNum.Next(1, 2);


            if (whoGoesFirst == 1)
            {
                string FirstPlayer = Player1;
                string SecondPlayer = Player2;
            }
            else
            {
                string FirstPlayer = Player2;
                string SecondPlayer = Player1;
            }
            // do a for loop 9 times for each player.
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    // Ensure number is between 1 and 9?
                    // Error message that won't allow me to add in FirstPlayer
                    Console.WriteLine("Which number on the board would you like to choose?");
                    int NumChoice = int.Parse(Console.ReadLine());
                    // Add choice to array
                    // Use that to display modified board
                }
                else
                {
                    Console.WriteLine("Which number on the board would you like to choose?");
                    int NumChoice = int.Parse(Console.ReadLine());
                    // Add choice to array
                    // Use that to display modified board
                }
            }


        }
    }
}
