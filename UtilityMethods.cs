namespace adventureNovel;

class UtilityMethods
{
    public static int PromptAndValidateUserInput(string[] userOptions)
    {
        Console.WriteLine("What do you do.");
        for (int i = 0; i < userOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {userOptions[i]}");
        }

        string? userInput = "";
        int userAnwser;
        bool validInput;

        do
        {
            Console.Write("Enter choice: ");
            userInput = Console.ReadLine();
            validInput = Int32.TryParse(userInput, out userAnwser);

            if (validInput == false)
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (userAnwser <= 0 || userAnwser > userOptions.Length)
            {
                validInput = false;
                Console.WriteLine($"Enter an option between 1 and {userOptions.Length}");
            }
        }
        while (validInput == false);
        Console.WriteLine();

        return userAnwser;
    }
}