/**
*   This class centralizes all the user interface functions
**/

static class UI{

    //Show the system header
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

    //Ask, recive and validate a string answer
    public static int IntField(string question)
    {
        int number;
        do{ //while number is less than 0

            // show the question on console
            Console.WriteLine(question);
        
            // recive the answer
            string? sNumber = Console.ReadLine(); 
        
            // Tray parse string to int
            bool parseResult = int.TryParse(sNumber! , out number);
            //If is not successeful show a error mensage
            if (!parseResult) {
                ShowErrorMessages("Invalid number, please try again");
            }
        }while(number < 0);
        return number; //Return informed number
    }

//Ask, recive and validate a yes/no y/n answer
    public static bool YesNoField(string question)
    {
        bool result = false;    // recive the answer
        bool valid = false;     // is a valid answer
        while (!valid)
        {
            Console.WriteLine($"{question} (Entre Y/N or YES/NO)");
            string? answer = Console.ReadLine();
            answer = answer?.ToLower();     //transfor string to lowercase
            answer = answer?.Trim();        //remove whitespaces
    
            if (answer == "y" || answer == "yes") { //check the answer is yes and return true
                result = true;
                valid = true;
            } else if (answer == "n" || answer == "no") { //check the answer is no and return false
                result = false;
                valid = true;
            } else { //If answer is not yes or no show a error mensage
                ShowErrorMessages("Invalid answer, please try again");
            }
        }
        return result;
    }
    
    public static void ShowErrorMessages(string message){
                Console.ForegroundColor = ConsoleColor.Red; // change font color to red
                Console.WriteLine(message); //show menssage
                Console.ResetColor(); // reset font color
    }

    public static void ShowSuccessMessages(string message){
                Console.ForegroundColor = ConsoleColor.Green; // change font color to green
                Console.WriteLine(message); //show menssage
                Console.ResetColor(); // change font color to red
    }
}