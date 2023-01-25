using System;
namespace Mission3Assignment
{
    public class SupportingClass
    {
        // method to determine winner
        public string Winner(char[] arr, string p1, string p2)
        {
            string one = p1 + " Wins";
            string two = p2 + " Wins";
            string draw = "Draw!";

            //option1
            if ((arr[1] & arr[2] & arr[3]) == 'X')
            {
                return one;
            }
            else if ((arr[1] & arr[2] & arr[3]) == 'O')
            {
                return two;
            }
            //option2
            else if ((arr[4] & arr[5] & arr[6]) == 'X')
            {
                return one;
            }
            else if ((arr[4] & arr[5] & arr[6]) == 'O')
            {
                return two;
            }
            //option3
            else if ((arr[7] & arr[8] & arr[9]) == 'X')
            {
                return one;
            }
            else if ((arr[7] & arr[8] & arr[9]) == 'O')
            {
                return two;
            }
            //option4
            else if ((arr[1] & arr[5] & arr[9]) == 'X')
            {
                return one;
            }
            else if ((arr[1] & arr[5] & arr[9]) == 'O')
            {
                return two;
            }
            //option5
            else if ((arr[3] & arr[5] & arr[7]) == 'X')
            {
                return one;
            }
            else if ((arr[3] & arr[5] & arr[7]) == 'O')
            {
                return two;
            }
            //option6
            else if ((arr[1] & arr[4] & arr[7]) == 'X')
            {
                return one;
            }
            else if ((arr[1] & arr[4] & arr[7]) == 'O')
            {
                return two;
            }
            //option7
            else if ((arr[2] & arr[5] & arr[8]) == 'X')
            {
                return one;
            }
            else if ((arr[2] & arr[5] & arr[8]) == 'O')
            {
                return two;
            }
            //option8
            else if ((arr[3] & arr[6] & arr[9]) == 'X')
            {
                return one;
            }
            else if ((arr[3] & arr[6] & arr[9]) == 'O')
            {
                return two;
            }
            else
            {
                return draw;
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