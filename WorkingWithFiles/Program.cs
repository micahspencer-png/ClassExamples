namespace WorkingWithFiles
{
    internal class Program
    {
        static void WriteFile(string path) 
        { 
             //open/create a new file to write text
            //overwrites existing data

            //using (StreamWriter testFile = File.CreateText(path))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        testFile.WriteLine("This is a line of text");
            //    }
            //}
        }

        static void AppendFile(string path) 
        {
            ////opens/creates a new file to append text
            ////adds new data to existing data
            //using (StreamWriter testFile = File.AppendText(path))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        testFile.WriteLine("Append this line of text");
            //    }
            //}
        }

        static void ReadFile(string path) 
        {
            using (StreamReader testFile = new StreamReader(path)) 
            {
                //returns values in file and empty lines if all values are used
                //for (int i = 0; i < 30; i++)
                //{
                //    Console.WriteLine(testFile.ReadLine());
                //}

                //displays all values in file and stops at end of file
                do
                {
                    Console.WriteLine(testFile.ReadLine());
                }while (testFile.EndOfStream == false);
            }
        }

        static void Main(string[] args)
        {
            //string path = "test.txt";
            string path = "..\\..\\..\\email.txt";
            string customer = "";
            string[] temp;

            using (StreamReader testFile = new StreamReader(path))
            {
                do
                {
                    customer = testFile.ReadLine();
                    temp = customer.Split(",");
                    foreach (var record in temp)
                    {
                        Console.Write(record.PadRight(15));
                    }
                    Console.WriteLine();

                } while (testFile.EndOfStream == false);
            }

            //ReadFile(path);

            // File.AppendText("Hello?");

            Console.Read();
        }
    }
}
