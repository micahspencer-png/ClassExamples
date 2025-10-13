namespace ListExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor
            List<string> names = new List<string>();

            //adds data to list in order
            names.Add("Jack");
            names.Add("Jill");
            names.Add("Bob");
            names.Add("Mary");
            names.Add("Sam");
            names.Add("Derick");
            names.Add("Steve");
            names.Add("Martin");
            names.Add("Selena");

            //writes the index number for "Sam"
            Console.WriteLine(names.IndexOf("Sam"));

            //inserts new data at specified index
            //higher indexes shift up
            names.Insert(4, "Dave");

            //removes an item from list
            //all indexes below value shift down
            names.Remove("Jill");

            //removes data at index
            //all indexes below shift down
            names.RemoveAt(3);

            //sorts by value
            names.Sort();

            //writes all data and their indexes
            foreach (string name in names)
            {
                Console.WriteLine($"{name} is at index: {names.IndexOf(name)}");
            }

            //pause
            Console.Read();
        }
    }
}
