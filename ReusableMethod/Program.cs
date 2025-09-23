using System.ComponentModel.Design;
using System.Threading.Tasks.Dataflow;

namespace ReusableMethod
{
    internal class Program
    {
        /*
         *  Define a function that takes a string message and appends it to an accumulating result (e.g., a log or transcript).
            Allow the user to enter multiple messages, accumulating them until the user chooses to stop.
            Display the accumulated messages at the end.
            Wait for the user to press Enter before closing the console window.
            Remember to include the standard program information header in your code.
         */
        static void Main(string[] args)
        {
            string userMessages = "This is important";
            string allTheMessages = "";
            bool quit = false;

            Console.WriteLine("Type Data You Want Stored. Press Q to Show All Data");
            do
            {
                userMessages = Console.ReadLine();
                if (userMessages != "q" && userMessages != "Q")
                {
                    allTheMessages = Messages(userMessages);
                    Console.Clear();
                }
                else
                {
                    quit = true;
                }
            } while (quit == false);
            
            Console.Clear();
            Console.WriteLine("The Messages Typed Are:");
            Console.WriteLine(allTheMessages);
            
            //pause
            Console.WriteLine("Press Enter to Quit");
            Console.Read();
        }

        private static string _messages = ""; 
        

        static string Messages(string userMessages)
        {
            userMessages = userMessages.Trim();
            //grabs global
            string messages = _messages;
            
            if (messages.Length == 0)
            {
                messages += userMessages;
            }

            //skips a blank input
            else if (userMessages != "")
            {
                //append the current message
                messages += "\n" + userMessages;
            }
       
            //stores the updated data
            _messages = messages;
                
            //return the messages
            return messages;
        }
    }
}
