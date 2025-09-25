using System.ComponentModel.Design;

namespace ValidationExample
{
    //Take two arguments: a string value to be converted, and an out integer variable to store the result.
    //Return a boolean indicating if the conversion was successful.
    //If successful, update the out integer variable with the converted value.
    //If not, do not update the integer variable.
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string userInput;
            bool quitProgram = false;
            
            do
            {
                Console.WriteLine("Please input a Number. Press Q to Quit");
                userInput = Console.ReadLine();
               
                ConvertandValidate(userInput,ref number);

                if (userInput == "q" || userInput == "Q")
                {
                    quitProgram = true;
                }
                else
                {
                    if (ConvertandValidate(userInput, ref number) == true)
                    {
                        Console.WriteLine($"{number} + 5 = {number + 5}");
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} isn't a number");
                    }

                    
                }
            }while (quitProgram == false);

            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }   

        static bool ConvertandValidate(string userInput, ref int number)
        {
            try
            {
                number = int.Parse(userInput);
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }
    }
}
