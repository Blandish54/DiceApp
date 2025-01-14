using System;
using System.Text;


namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal billTotal = 0;
            bool isUserBillANumber = true;
            bool isUserPercentageANumber = true;
            bool isAnotherBillToTotal = true;
            
            Console.WriteLine("Thank you for opening the Tip Calculator App");

            Console.WriteLine("Enter the total of your bill to continue");
            string userTotal = Console.ReadLine();

            while (isAnotherBillToTotal)
            {
                decimal wholeTotal = 0;
                decimal tipTotal = 0;
                decimal tipPercentage = 0;

                isUserBillANumber = decimal.TryParse(userTotal, out billTotal);

                if (isUserBillANumber == false)
                {
                    Console.WriteLine("Please enter a number to continue");
                    userTotal = Console.ReadLine();
                    continue;
                }



                Console.WriteLine("Please enter the percentage you would like to tip.");
                string userPercentage = Console.ReadLine();

                isUserPercentageANumber = decimal.TryParse(userPercentage, out tipPercentage);


                while (isUserPercentageANumber == false)
                {
                    //Is this needed?
                    userPercentage = null;
                    tipPercentage = 0;

                    Console.WriteLine("Please enter a number as a percentage to continue.");
                    userPercentage = Console.ReadLine();
                    isUserPercentageANumber = decimal.TryParse(userPercentage, out tipPercentage);

                    //Is this needed?
                    if (isUserPercentageANumber == true)
                    {
                        continue;
                    }
                }


                decimal decimalBillTotal = Convert.ToDecimal(billTotal);

                billTotal = Math.Round(billTotal, 2);

                tipTotal = (decimalBillTotal * (tipPercentage / 100));

                tipTotal = Math.Round(tipTotal, 2);

                wholeTotal = tipTotal + billTotal;



                Console.WriteLine($"The total tip should be ${tipTotal} and the bill should equal ${wholeTotal}");
                Console.WriteLine("Did you have another bill you would like to total? If so enter the total now");
                userTotal = Console.ReadLine();

                isUserBillANumber = decimal.TryParse(userTotal, out billTotal);

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
        }
    }
}
