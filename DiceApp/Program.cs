﻿using System.ComponentModel.Design;
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
    int diceSelection = 0;
    bool isSidesANumber = false;
    bool isFirstSidesLoop = true;

    while (isSidesANumber == false)
    {
        if (isFirstSidesLoop)
        {
            Console.WriteLine("First we need to select what kind of die you would like to roll");
            Console.WriteLine("Enter a: 1 to flip a coin");
            Console.WriteLine("Enter a: 2 to roll a standard 6-sided die");
            Console.WriteLine("Enter a: 3 to roll a 10-sided die");
            Console.WriteLine("Enter a: 4 to roll a 20-sided die");
            Console.WriteLine("Enter a: 5 to roll a 100-sided die");
            
            Console.ReadLine();
            
            isFirstSidesLoop = false;
        }
       else
        {
         Console.WriteLine("Enter the number of times you would like to roll your selected die or coin.");
        }
        string howManySides = Console.ReadLine();

        isSidesANumber = Int32.TryParse(howManySides, out diceSelection);
        
        
    }
    int numberOfDice = 0;
    bool isDiceInputOk = false;
    bool isFirstDiceLoop = true;

    while (isDiceInputOk == false)
    {

        if (isFirstDiceLoop)
        {
            Console.WriteLine("Also, enter the number of dice you would like to roll.");
            isFirstDiceLoop = false;
        }
        else
        {
            Console.WriteLine("It looks like you failed to enter a number.");
            Console.WriteLine("Enter a number to continue.");
        }

        string howManyDice = Console.ReadLine();


        isDiceInputOk = Int32.TryParse(howManyDice, out numberOfDice);
     }
    switch (diceSelection)
    {
        case 0:
            = randomDiceGenerator.Next(1, 2);
            break;
        case 1:
            int standardDie = randomDiceGenerator.Next(1, 6);
            break;
        case 2:
            int d10 = randomDiceGenerator.Next(1, 10);
            break;
        case 3:
            int d20 = randomDiceGenerator.Next(1, 20);
            break;
        case 4:
            int d100 = randomDiceGenerator.Next(1, 100);
            break;
        default:
            
            Console.WriteLine("It seems you have entered an incorrect input.");
            Console.WriteLine("Please select an input from the list above");

            Console.ReadLine();
            
            
        }       
    

    int rollValues = 0;
    int sum = 0;
    for (int i = 1; i <= numberOfDice ; i++)
    {
        rollValues = randomDiceGenerator.Next(1, diceSelection);

        Console.WriteLine(rollValues);

        sum += rollValues;
    }

     

    Console.WriteLine($"You Rolled a total of: {sum} ");
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






