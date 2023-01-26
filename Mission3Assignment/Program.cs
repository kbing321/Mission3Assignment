using System;

namespace Mission3Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool keepPlaying = true;

            SupportingClass sc = new SupportingClass(); //declaration and instantiation
            
            // loop to let user's keep playing as many times as they want
            while (keepPlaying == true)
            {
                char[] PlayerChoice = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int i = 1;

                // Welcome users to the game and get user names
                Console.WriteLine("Welcome to this game of Tic Tac Toe!");
                Console.WriteLine("Please enter the first player's Name:");
                string Player1 = Console.ReadLine();
                Console.WriteLine("Please enter the second player's Name:");
                string Player2 = Console.ReadLine();

                // method call to display the board
                sc.Board(PlayerChoice);

                // loop to let users place Xs and Os until a player wins or board is full
                while (i < 10)
                {   
                    if (i % 2 == 1)
                    {
                        // Receive board spot choice on each of player 1's turn
                        Console.WriteLine("Which number on the board would you like to choose, {0}?", Player1);
                        int NumChoice = int.Parse(Console.ReadLine());

                        // Add player 1 choice to array if spot not already taken
                        if (PlayerChoice[NumChoice] == 'O' || PlayerChoice[NumChoice] == 'X')
                        {
                            Console.WriteLine("That spot has already been taken, pick another one!");
                            continue;
                        }
                        else
                        {
                            PlayerChoice[NumChoice] = 'X';
                        }
                    }
                    else
                    {
                        // Receive board spot choice on each of player 2's turn
                        Console.WriteLine("Which number on the board would you like to choose, {0}?", Player2);
                        int NumChoice = int.Parse(Console.ReadLine());

                        // Add player 2 choice to array if spot not already taken
                        if (PlayerChoice[NumChoice] == 'O' || PlayerChoice[NumChoice] == 'X')
                        {
                            Console.WriteLine("That spot has already been taken, pick another one!");
                            continue;
                        }
                        else
                        {
                            PlayerChoice[NumChoice] = 'O';
                        }
                    }

                    Console.Clear();

                    //print out updated board
                    sc.Board(PlayerChoice);

                    string result = sc.Winner(PlayerChoice, Player1, Player2);

                    // check for either a draw or a win on last spot, or a win on any but the last spot to play on
                    if (i == 9)
                    {
                        if (result == "Draw!")
                        {
                            Console.WriteLine(result);
                            i = 10;
                        }
                        else
                        {
                            Console.WriteLine(result);
                            i = 10;
                        }
                    }
                    else
                    {
                        if (result == Player1 + " Wins!" || result == Player2 + " Wins!")
                        {
                            Console.WriteLine(result);
                            i = 10;
                        }
                    }
                    i++;
                }

                // Ask users if they want to play again 
                Console.WriteLine("Great game!\nWould you like to play again?(y/n)");
                char play = char.Parse(Console.ReadLine());

                if (play == 'y')
                {
                    Console.Clear();
                    keepPlaying = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    keepPlaying = false;
                }
            }
        }
    }
}