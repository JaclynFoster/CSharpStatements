namespace IfStatements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the temp outside?");
        string temp = Console.ReadLine();
        int numTemp = int.Parse(temp);

        if (numTemp < 70)
        {
            Console.WriteLine("Take a coat!");
        }
        else if (numTemp == 70)
        {
            Console.WriteLine("It is just right outside.");
        }
         else
        {
            Console.WriteLine("It is a little warmer outside!");
        }

        Console.Read();

        //tryParse is used when a user enters input and needs to convert a string to integer
        string numAsString = "128";
        int parsedValue;
        bool success = int.TryParse(numAsString, out parsedValue);
        //the return boolean is true when parsing was successful
        if(success)
        {
            Console.WriteLine("Parsing successful-number is " + parsedValue);
        }
        else
        {
            Console.WriteLine("Parsing Failed");
        }
    }
}

