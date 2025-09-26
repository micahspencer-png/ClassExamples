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
            Console.WriteLine(new string('-',25));
            foreach (string letter in header)
            {
                Console.Write(letter.PadLeft(3) + "  "); 
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

        }

        static void Check() 
        {
            //checks if number is available

        }
    }
}
