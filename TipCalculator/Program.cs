// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

double billTotal = 0;
bool isUserBillANumber = true;
bool isUserPercentageANumber = true;
bool isAnotherBillToTotal = true;

Console.WriteLine("Thank you for opening the Tip Calculator App");
Console.WriteLine("Enter the total of your bill to continue");
string userTotal = Console.ReadLine();

while (isAnotherBillToTotal)
{
    double tipDisplay = 0;
    double wholeTotal = 0;
    decimal tipTotal = 0;
    decimal tipPercentage = 0;

    isUserBillANumber = double.TryParse(userTotal, out billTotal);

    if (isUserBillANumber == false)
    {
        Console.WriteLine("Please enter a number to continue");
        userTotal = Console.ReadLine();
    }
    else
    {
        isUserBillANumber = true;
    }

    Console.WriteLine("Please enter a whole number for the Tip Percentage.");
    string userPercentage = Console.ReadLine();

    isUserPercentageANumber = decimal.TryParse(userPercentage, out tipPercentage);

    if (isUserPercentageANumber == false)
    {
        Console.WriteLine("Please enter a number to continue");
        userPercentage = Console.ReadLine();
    }
    else
    {
        isUserPercentageANumber = true;
    }
    decimal decimalBillTotal = Convert.ToDecimal(billTotal);

    billTotal = Math.Round(billTotal, 2);

    tipTotal = (decimalBillTotal * (tipPercentage / 100));

    tipDisplay = Convert.ToDouble(tipTotal);

    tipDisplay = Math.Round(tipDisplay, 2);

    wholeTotal = tipDisplay + billTotal;

    Console.WriteLine($"The total tip should be {tipDisplay} and the bill should equal {wholeTotal}");
    Console.WriteLine("Did you have another bill you would like to total? If so enter the total now");
    userTotal = Console.ReadLine();

    isUserBillANumber = double.TryParse(userTotal, out billTotal);

    if (isUserBillANumber == false)
    {
        Console.WriteLine("Good-Bye<3");
        break;
    }
    else
    {
        continue;
    }
}