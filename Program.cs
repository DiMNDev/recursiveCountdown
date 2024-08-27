// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

Timer _timer;
void countDownFromNumber(int countDownFrom = 10, int currentNumber = -1)
{
    if (currentNumber < countDownFrom)
    {
        countDownFromNumber(countDownFrom, currentNumber + 1);
        currentNumber++;
        printCount(currentNumber);
        if (currentNumber == 0)
        {
            Console.Beep(600, 700);
            Console.WriteLine("BLAST OFF! 🚀");
        }
    }

}

countDownFromNumber(10);

static async Task printCount(int currentNumber)
{
    Task.Delay(1000);
    Console.Beep(400, 400);
    Console.WriteLine(currentNumber);
}