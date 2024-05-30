static class UI{
    public static void SystemHeader()
    {
        Console.Clear();
        Console.WriteLine("#----------------------------------#");
        Console.WriteLine("#  GROCERY BILLING SYSTEM          #");
        Console.WriteLine("#  By Rodrigo Bruner               #");
        Console.WriteLine("#  Studen #: 8993586               #");
        Console.WriteLine("#  rbruner3586@conestogac.on.ca    #");
        Console.WriteLine("#----------------------------------#\n\n");
    }

    public static int IntField(string question)
    {
        int number;
        do{
            Console.WriteLine(question);
            string? sNumber = Console.ReadLine();
            bool parseResult = int.TryParse(sNumber! , out number);
            if (!parseResult) {
                ShowErrorMessages("Invalid number, please try again");
            }
        }while(number < 0);
        return number;
    }

    public static bool YesNoField(string question)
    {
        bool result = false;
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine($"{question} (Entre Y/N or YES/NO)");
            string? answer = Console.ReadLine();
            answer = answer?.ToLower(); 
            answer = answer?.Trim();
    
            if (answer == "y" || answer == "yes") {
                result = true;
                valid = true;
            } else if (answer == "n" || answer == "no") {
                result = false;
                valid = true;
            } else {
                ShowErrorMessages("Invalid answer, please try again");
            }
        }
        return result;
    }
    
    public static void ShowErrorMessages(string message){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
    }

    public static void ShowSuccessMessages(string message){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
    }
}