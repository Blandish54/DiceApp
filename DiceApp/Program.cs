using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

//As a user of this dice app
//I want the ability to see the value of each die I rolled along with the sum total
//So I can see what each die's value was

bool rollDiceAgain = true;
Random randomDiceGenerator = new Random();

Console.WriteLine("Hello and Welcome to The Dice App");

while (rollDiceAgain)
{
    int numberOfSides = 0;
    bool isUserDiceInputValid = false;
    bool isFirstUserDiceInputLoop = true;

    while (isUserDiceInputValid == false)
    {
        if (isFirstUserDiceInputLoop)
        {
            Console.WriteLine("First we need to select what kind of die you would like to roll");
            Console.WriteLine("Enter a: 1 to flip a coin");
            Console.WriteLine("Enter a: 2 to roll a standard 6-sided die");
            Console.WriteLine("Enter a: 3 to roll a 10-sided die");
            Console.WriteLine("Enter a: 4 to roll a 20-sided die");
            Console.WriteLine("Enter a: 5 to roll a 100-sided die");

            isFirstUserDiceInputLoop = false;
        }
        else
        {
            Console.WriteLine("Enter");
            Console.WriteLine("1 to flip a coin");
            Console.WriteLine("2 to roll a standard 6-sided die");
            Console.WriteLine("3 to roll a 10-sided die");
            Console.WriteLine("4 to roll a 20-sided die");
            Console.WriteLine("5 to roll a 100-sided die");
            Console.WriteLine("Please make your selection from the list above to continue.");
        }

        string userDiceInput = Console.ReadLine();


        switch (userDiceInput)
        {
            case "1":
                numberOfSides = 2;
                break;
            case "2":
                numberOfSides = 6;
                break;
            case "3":
                numberOfSides = 10;
                break;
            case "4":
                numberOfSides = 20;
                break;
            case "5":
                numberOfSides = 100;
                break;

            default:

                Console.WriteLine("Please select an input from the list below");
                continue;
        }
        isUserDiceInputValid = true;

    }
    
    int numberOfDice = 0;
    bool isDiceInputOk = false;
    bool isFirstDiceLoop = true;

    while (isDiceInputOk == false)
    {

        if (isFirstDiceLoop)
        {
            Console.WriteLine("Enter the number of times you would like to roll your selected die or coin.");

            isFirstDiceLoop = false;
        }
        else
        {
            Console.WriteLine("It looks like you failed to enter a number.");
            Console.WriteLine("Enter a number to continue.");
        }
        string numberOfRolls = Console.ReadLine();

        isDiceInputOk = Int32.TryParse(numberOfRolls, out numberOfDice);
    }

    int rollValue = 0;
    int sumOfRolls = 0;
    
    for (int i = 1; i <= numberOfDice; i++)
    {
        rollValue = randomDiceGenerator.Next(1, numberOfSides + 1);

        Console.WriteLine($"Roll number {i} was a:{rollValue}");

        sumOfRolls += rollValue;
    }

    Console.WriteLine($"You Rolled a total of: {sumOfRolls} ");
    Console.WriteLine("Would you like to roll again?");
    Console.WriteLine("Enter Y/N");

    string userInput = Console.ReadLine();

    if (userInput == "y" || userInput == "Y")
    {
        continue;
    }
    else
    {
        break;
    }
}






