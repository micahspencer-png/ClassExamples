namespace WorkingWithFiles
{
    internal class Program
    {
        static void WriteFile(string path) 
        {
            //open / create a new file to write text
           //overwrites existing data

            using (StreamWriter testFile = File.CreateText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("This is a line of text");
                }
            }
        }

        static void AppendFile(string path) 
        {
            ////opens/creates a new file to append text
            ////adds new data to existing data
            using (StreamWriter testFile = File.AppendText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("Append this line of text");
                }
            }
        }

        static void ReadFile(string path) 
        {
            using (StreamReader testFile = new StreamReader(path)) 
            {
                //returns values in file and empty lines if all values are used
                for (int i = 0; i < 30; i++)
                {
                    Console.WriteLine(testFile.ReadLine());
                }

                //displays all values in file and stops at end of file
                do
                {
                    Console.WriteLine(testFile.ReadLine());
                }while (testFile.EndOfStream == false);
            }
        }

        static void AddCustomer(string path, string[] customerData) 
        { 
            using (StreamWriter customerDataFile = File.AppendText(path))
            {
                string _customerData = "";

                //foreach (string customerRecord in customerData) 
                //{
                //    _customerData += customerRecord;

                //}
                try
                {
                    _customerData = $"{customerData[0]}{customerData[1]}{customerData[2]}{customerData[3]}{customerData[4]}";
                    customerDataFile.WriteLine($"{_customerData}\n");
                }
                catch (Exception ex)
                {
                    //log record and error description to log file
                    //get exception message
                    Console.WriteLine($"{ex.StackTrace}\n\n{customerData.Length}");
                    
                }

                
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
          
                    do
                    {
                        customer = testFile.ReadLine();
                        temp = customer.Split(",");
                           

                        //Console.Write($"Length : {temp.Length}".PadRight(15));

                        for (int i = 0; i < temp.GetUpperBound(0); i++)
                        {
                            temp[i] = temp[i].Replace('"', '$');
                            temp[i] = temp[i].Replace("$", "");
                            Console.WriteLine(i + ": " + temp[i]);
                        }
                        AddCustomer("..\\..\\..\\CustomerDB.txt", temp);

                        //foreach (string record in temp)
                        //{
                        //    formatRecord = record.Replace('"', '$');
                        //    formatRecord = formatRecord.Replace("$","");
                        //    //Console.Write(formatRecord.PadRight(15));

                        //    Console.WriteLine(record.Count());
                        //}
                        Console.WriteLine();

                    } while (testFile.EndOfStream == false);
                
                
            }

            //ReadFile(path);

            // File.AppendText("Hello?");

            Console.Read();
        }
    }
}
