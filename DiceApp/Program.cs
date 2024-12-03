using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

//TIP: try a "for" loop
//As a user of this dice app
//I want the ability to also say how many dice I should roll 
//so I can roll multiple of the same die and get the sum of their values

//As a user of this dice app
//I want the ability to see the value of each die I rolled along with the sum total
//So I can see what each die's value was

bool rollDiceAgain = true;
Random randomDiceGenerator = new Random();

Console.WriteLine("Hello and Welcome to The Dice App");
Console.WriteLine("Please enter the number of sides you would like your die to have");

while (rollDiceAgain)
{
    Console.WriteLine("Enter a number between 2 and 100");

    string howManySides = Console.ReadLine();

    int sidesConverted;

    bool isUserInputOk = Int32.TryParse(howManySides, out sidesConverted);
    if (isUserInputOk == false)
    {
        Console.WriteLine("It seems you have entered an incorrect input.");

        continue;
    }
    int rollValue = randomDiceGenerator.Next(1, sidesConverted);

    Console.WriteLine($"You Rolled a: {rollValue} ");
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






