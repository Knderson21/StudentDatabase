int answer = 1;

bool tryAgain = true;

while (tryAgain)
{
    string[] studentsName = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
    string[] studentsFood = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk Chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "Tacos", "Pasta", "Pounded Yam" };
    string[] studentsHometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

    while (true)
    {
        Console.WriteLine("Which student would you like to learn more about? Enter a number 1-17:");
        answer = int.Parse(Console.ReadLine());

        if (answer > 0 && answer <= studentsName.Length)
        {
            break;
        }
        Console.WriteLine("That was not a valid number.");
    }

    int index = answer - 1;

    
    

while (true)
    {
        Console.WriteLine($"Student {answer} is {studentsName[index]}. What would you like to know? Enter 'Hometown' or 'Favorite Food':");
        string choice1 = Console.ReadLine();

        if ("hometown".Contains(choice1.ToLower().Trim()))
        {
            Console.WriteLine(studentsName[index] + " is from " + studentsHometown[index]);
        }
        else if ("favorite food".Contains(choice1.ToLower().Trim()))
        {
            Console.WriteLine(studentsName[index] + "'s favorite food is " + studentsFood[index]);
        }
        else
        {
            Console.WriteLine("That category does not exist. Please try again.");
            continue;
        }
        break;
    }
    


    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string continueChoice = Console.ReadLine();
        if (continueChoice.ToLower().Trim() == "y")
        {
            break;
        }
        else if (continueChoice.ToLower().Trim() == "n")
        {
            tryAgain = false;
            break;
        }
    }
}
    Console.WriteLine("Goodbye!");



