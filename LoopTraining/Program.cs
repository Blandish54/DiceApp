int[] numbers = new int[] { 5, 1, 8, 9, 11, 6, 7 };

//for loop
for (int i = 0; i < numbers.Length; i = i + 1)
{
    Console.WriteLine(numbers[i]);
}
Console.ReadLine();


//while loop
int indexStart = 0;
int indexEnd = 5;
while (indexStart != indexEnd)
{
    Console.WriteLine(numbers[indexStart]);

    indexStart += 1;
}


//foreach loop
foreach (int number in numbers)
{
    Console.WriteLine(number);
}