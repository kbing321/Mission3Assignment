using System;
namespace Mission3Assignment
{
    public class SupportingClass
    {
        public void Winner(char[] arr, int GamePlay)
        {
            //loop to determine winner
            for (int i = 0; i < arr.Length; i++)
            {
                //option1
                if ((arr[1] & arr[2] & arr[3]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[1] & arr[2] & arr[3]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option2
                else if ((arr[4] & arr[5] & arr[5]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[4] & arr[5] & arr[6]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option3
                else if ((arr[7] & arr[8] & arr[9]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[7] & arr[8] & arr[9]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option4
                else if ((arr[1] & arr[5] & arr[9]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[1] & arr[5] & arr[9]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option5
                else if ((arr[3] & arr[5] & arr[7]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[3] & arr[5] & arr[7]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option6
                else if ((arr[1] & arr[4] & arr[7]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[1] & arr[4] & arr[7]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option7
                else if ((arr[2] & arr[5] & arr[8]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[2] & arr[5] & arr[8]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                //option8
                else if ((arr[3] & arr[6] & arr[9]) == 'X')
                {
                    Console.WriteLine("Player 1 Wins!");
                    GamePlay = 1;
                }
                else if ((arr[3] & arr[6] & arr[9]) == 'O')
                {
                    Console.WriteLine("Player 2 Wins!");
                    GamePlay = 1;
                }
                else
                {
                    Console.WriteLine("Draw!");
                    GamePlay = -1;
                }
            }
        }
     
        public void Board(char[] arr)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}