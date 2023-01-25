using System;

namespace Mission3Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SupportingClass sc = new SupportingClass(); //declaration and instantiation
            bool keepPlaying = true;

            Console.WriteLine("Welcome to this game of Tic Tac Toe!");
            Console.WriteLine("Please enter Player1's Name:");
            string Player1 = Console.ReadLine();
            Console.WriteLine("Please enter Player2's Name:");
            string Player2 = Console.ReadLine();

            char[] PlayerChoice = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            // method to display the board

            int GamePlay = 0;
            
            // do a for loop 9 times for each player.
            while (keepPlaying == true)
            {
                while (GamePlay == 0)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        sc.Board(PlayerChoice);
                        if (i % 2 == 1)
                        {
                            // Ensure number is between 1 and 9?
                            // Error message that won't allow me to add in FirstPlayer

                            Console.WriteLine("Which number on the board would you like to choose {0}?", Player1);
                            int NumChoice = int.Parse(Console.ReadLine());
                            // Add choice to array
                            PlayerChoice[NumChoice] = 'X';
                            // Use that to display modified board
                        }
                        else
                        {
                            Console.WriteLine("Which number on the board would you like to choose {0}?", Player2);
                            int NumChoice = int.Parse(Console.ReadLine());
                            // Add choice to array
                            PlayerChoice[NumChoice] = 'O';
                            // Use that to display modified board
                        }
                    }
                }

                Console.WriteLine("Great game!\nWould you like to play another game?(y/n)");
                char play = char.Parse(Console.ReadLine());

                if (play == 'y')
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }
            }
        }
    }
}


// maybe use a random number between 1 and 2 to choose which player goes first
/*int whoGoesFirst = 0;
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
}*/