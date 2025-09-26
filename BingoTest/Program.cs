namespace BingoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display();

            Console.Read();
        }
        static void Display() 
        {
            //displays user interface
            string currentLocation = "XX";
            string[] header = { "B","I","N","G","O" };
            string vDivide = " |";
            int pad = 3;
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
                    Console.Write(currentLocation.PadLeft(3) + " |");
                }
                Console.WriteLine();
            }
        }
        static void Draw() 
        {
            //draws random number
            bool[,] bingoCage = new bool[4,14];
            Random draw1 = new Random();
            Random draw2 = new Random();

            int num1 = draw1.Next(0,5);
            int num2 = draw2.Next(0,15);

        }

        static void Check() 
        {
            //checks if number is available

        }
    }
}
