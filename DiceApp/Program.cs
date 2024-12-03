using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

//As a user of this dice app
//I want the ability to say how many sides my die has
//so I can roll different sized dice
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






