namespace IfStatements;

class Program
{
    static string user;
    static string password;

    static void Main(string[] args)
    {

        Register();
        Login();
        Console.Read();
        //Nested If Statements:
        bool isAdmin = false;
        bool isRegistered = true;
        string userName = "";
        Console.WriteLine("Please enter your Username:");
        userName = Console.ReadLine();

        if (isRegistered)
        {
            Console.WriteLine("Hi there,  registered user.");
            if (userName != "")
            {
                Console.WriteLine("Hi there, " + userName);
                if (userName.Equals("Admin"))
                {
                    Console.WriteLine("Hi there, Admin!");
                }
            }
        }

        if (isAdmin || isRegistered)
        {
            Console.WriteLine("You are logged in!");
        }
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

    //If Statement Challenge:
    public static void Register()
    {
        Console.WriteLine("Please Enter your username:");
        user = Console.ReadLine();
        Console.WriteLine("Please enter your password:");
        password = Console.ReadLine();
        Console.WriteLine("Registration is completed!");
        Console.WriteLine("------------------------------------");
    }

    public static void Login()
    {
        Console.WriteLine("Please enter your username:");
        if (user == Console.ReadLine())
        {
            Console.WriteLine("Please enter your password:");
            if (password == Console.ReadLine())
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed. Incorrect Password");
            }
        }
        else
        {
            Console.WriteLine("Login Failed, wrong username. Please Try Again.");
        }
    }
}

