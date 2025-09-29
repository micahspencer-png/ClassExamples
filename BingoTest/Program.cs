using System.Data;
using System.Net.Quic;

namespace BingoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            string userInput;
            Console.WriteLine("Press enter to draw ball. Type Q to quit.");
            userInput = Console.ReadLine();
            
            do
            {
                int row = 0;
                int column = 0;
                

                Draw(ref row, ref column);
                IsDrawn(row, column);
                Display();
                Console.WriteLine("Press Any Key to Redraw. Press Q to Quit");
                userInput = Console.ReadLine();
                Console.Clear();

                if (userInput == "q" || userInput == "Q") 
                {
                    quit = true;
                }

                else 
                {
                    quit = false;
                }

            } while (quit == false);

            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }

        static void Display() 
        {
            //displays user interface
            string currentLocation = "XX";
            string[] header = { "B","I","N","G","O" };
            int pad = 3;
            string vDivide =  " |";
            int totalWidth = 5 * (pad + vDivide.Length);
            string hDivide = new string('-', totalWidth);
            
            Console.WriteLine(hDivide);
           
            foreach (string letter in header)
            {
                Console.Write(letter.PadLeft(pad) + vDivide); 
            }
            Console.WriteLine();

            for (int row = 0; row < 15; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (IsDrawn(row,column)==false)
                    {
                        currentLocation = ((column * 15) + row + 1).ToString();   
                    }

                    else 
                    {
                        currentLocation = " ";
                    }
                    
                        Console.Write(currentLocation.PadLeft(pad) + vDivide);
                }
                Console.WriteLine();
            }
        }

        private static bool[,] ballCage= new bool[15, 5];

        static bool IsDrawn(int row, int column)
        {
            bool status = false;

            
            return status;
            
        }
        static void Draw(ref int row, ref int column) 
        {
            //draws random number
            Random draw1 = new Random();
            Random draw2 = new Random();

            row = draw1.Next(0,15);
            column = draw2.Next(0,5);
        }

        static void Check() 
        {
            //checks if number is available

        }
    }
}
