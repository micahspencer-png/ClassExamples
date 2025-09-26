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
                Console.Read();
            } while (quit = false);

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
                    if (IsDrawn(row,column))
                    {
                        currentLocation = "00";
                    }
                    else 
                    {
                        currentLocation = "XX";
                    }
                        Console.Write(currentLocation.PadLeft(pad) + vDivide);
                }
                Console.WriteLine();
            }
        }

        private static bool[,] ballCage= new bool[14, 4];

        static bool IsDrawn(int row, int column)
        {
            bool status = false;

            try 
            { 
                status = ballCage[row, column];
            }
            catch (Exception)
            {
                
            }
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
