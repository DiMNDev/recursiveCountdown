// See https://aka.ms/new-console-template for more information

void countDownFromNumber(int countDownFrom = 10, int currentNumber = -1)
{
    if (currentNumber < countDownFrom)
    {
        countDownFromNumber(countDownFrom, currentNumber + 1);
        currentNumber++;
        Console.WriteLine(currentNumber);
        if (currentNumber == 0)
        {
            Console.WriteLine("BLAST OFF! 🚀");
            Console.Beep(300, 200);
            Console.Beep(300, 200);
            Console.Beep(600, 200);
        }
    }

}

countDownFromNumber(20);