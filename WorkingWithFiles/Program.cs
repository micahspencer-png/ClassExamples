namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";

            //open/create a new file to write text
            //overwrites existing data

            using (StreamWriter testFile = File.CreateText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("This is a test line of text");  
                }
            }

            //opens/creates a new file to append text
            //adds new data to existing data
            using (StreamWriter testFile = File.AppendText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("Append this line of text");
                }
            }

            using (StreamReader testFile = new StreamReader(path)) 
            { 
                Console.Write(testFile.ReadLine());
            }
            // File.AppendText("Hello?");

            Console.Read();
        }
    }
}
