using System.ComponentModel.Design;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

//As a user of this dice app
//I want the ability to say how many sides my die has
//so I can roll different sized dice

Random randomDiceGenerator = new Random();

Console.WriteLine  ("Hello and Welcome to The Dice App");

Console.WriteLine  ("Please enter the number of sides you would like your die to have");
    
Console.WriteLine  ("Enter a number between 2 and 100");

string userInput = Console.ReadLine();

bool howManySides = false;

switch (howManySides)
{ 

    howManySides = true;
    
    int rollValue = randomDiceGenerator.Next(1,2);
   
    Console.WriteLine($"You Rolled a: {rollValue} ");}
  

  
else { 
    howManySides = false;}

  
   
bool rollDiceAgain = true;

Console.WriteLine("Would you like to roll again?");

Console.WriteLine("Enter Y/N");

while (rollDiceAgain)
{

    if (userInput == "y" || userInput == "Y")
    {
        continue;
    }
    else
    {
        break;
    }
}






