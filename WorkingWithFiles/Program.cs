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
            string formatRecord;

            using (StreamReader testFile = new StreamReader(path))
            {
                try
                {
                    do
                    {
                        customer = testFile.ReadLine();
                        temp = customer.Split(",");
                        foreach (string record in temp)
                        {
                            formatRecord = record.Replace('"', '$');
                            formatRecord = formatRecord.Replace(" ", "$");
                            formatRecord = formatRecord.Replace("$","");
                            Console.Write(formatRecord.PadRight(15));
                        }
                        Console.WriteLine();

                    } while (testFile.EndOfStream == false);
                }
                catch (Exception)
                {
                    Console.WriteLine("out of bounds");
                }
            }

            //ReadFile(path);

            // File.AppendText("Hello?");

            Console.Read();
        }
    }
}
