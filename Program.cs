// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

async void CountDownFromNumber(int countDownFrom = 10, int currentNumber = -1)
{
    if (currentNumber < countDownFrom)
    {
        CountDownFromNumber(countDownFrom, currentNumber + 1);
        currentNumber++;
        await PrintCount(currentNumber);
        if (currentNumber == 0)
        {
            Console.Beep(600, 700);
            Console.WriteLine("BLAST OFF! 🚀");
        }
    }

}

CountDownFromNumber(10);

static async Task PrintCount(int currentNumber)
{
    Task.Delay(500);
    Console.Beep(400, 500);
    Console.WriteLine(currentNumber);
}