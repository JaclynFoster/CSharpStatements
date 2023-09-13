namespace IfStatements;

class Program
{
    //Challenge 1 variables:
    static string user;
    static string password;

    //Challenge 2 variables:
    static int highscore = 300;
    static string highscorePlayer = "Jaclyn";

    static void Main(string[] args)
    {
        //Ternary Operator Challenge 3:
        int inputTemp = 0;
        string tempMessage = string.Empty;
        string inputValue = string.Empty;
        Console.Write("Enter the current Temperature:");
        inputValue = Console.ReadLine();
        //validate input as valid input integer value
        bool validInteger = int.TryParse(inputValue, out inputTemp);

        if (validInteger)
        {
            tempMessage = inputTemp <= 15 ? "it is too cold here" : (inputTemp >= 16 && inputTemp <= 28) ?
                "It is cold here" : inputTemp > 28 ? "It is hot here" : "";

            Console.WriteLine(tempMessage);
        } else
        {
            Console.WriteLine("Not a valid temperature");
        }

        //Ternary Operator Statements: condition ? first_expression: second_expression
        int temperature = -5;
        string stateOfMatter;
        if (temperature < 0)
        {
            stateOfMatter = "solid";
        } else
        {
            stateOfMatter = "liquid";
        }
        Console.WriteLine("State of matter is {0}", stateOfMatter);
        //Can change to ternary:
        stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

        Console.WriteLine("State of matter is {0}", stateOfMatter);

        temperature += 100;
        stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
        Console.WriteLine("State of matter is {0}", stateOfMatter);

        Console.Read();
        //Switch Statements:
        int age = 25;
        switch(age)
        {
            case 15:
                Console.WriteLine("Too young to party in the club");
                break;
            case 25:
                Console.WriteLine("Good to go!");
                break;
            default:
                Console.WriteLine("How old are you then?");
                break;
        }

        if (age == 15)
        {
            Console.WriteLine("Too young to party in the club");
        } else if (age == 25)
        {
            Console.WriteLine("Good to go!");
        }
        else
        {
            Console.WriteLine("How old are you then?");
        }

        //switch with strings:
        string name = "";
        switch (name)
        {
            case "Jaclyn":
                Console.WriteLine("Your name is Jaclyn");
                break;
            case "Chris":
                Console.WriteLine("Your name is Chris!");
                break;
            default:
                Console.WriteLine("What is your name?");
                break;
        }       




        Console.Read();
        //Challenge 1 Method Calls:
        Register();
        Login();
        Console.Read();

        //Challenge 2 Method Calls:
        CheckHighScore(250, "Maria");
        CheckHighScore(315, "Michael");
        CheckHighScore(350, "Jaclyn");
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

        Console.ReadKey();
    }

    //If Statement Challenge 1:
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

    //If Statement Challenge 2:
    public static void CheckHighScore(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;

            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New Score now held by: " + playerName);
        } else
        {
            Console.WriteLine("The old highscore could not be broken. It is still: " + highscore + "held by " + highscorePlayer);
        }
    }
}

