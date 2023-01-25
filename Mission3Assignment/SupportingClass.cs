using System;
namespace Mission3Assignment
{
    public class SupportingClass
    {
        public SupportingClass()
        {
            int[] board = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] player1 = new int[] { };
            int[] player2 = new int[] { };
            int[] win1 = { 1, 2, 3 };
            int[] win2 = { 4, 5, 6 };
            int[] win3 = { 7, 8, 9 };
            int[] win4 = { 1, 4, 7 };
            int[] win5 = { 2, 5, 8 };
            int[] win6 = { 3, 6, 9 };
            int[] win7 = { 1, 5, 9 };
            int[] win8 = { 3, 5, 7 };

            for (int i = 0; i < player1.Length; i++)
            {

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
