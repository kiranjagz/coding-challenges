
Console.WriteLine("Outside the loop");

int numberOfTimes = 5; // Number of times to display "Hello, World!"

await Task.Run(() =>
{
    for (int i = 0; i < numberOfTimes; i++)
    {
        Console.WriteLine("Hello, World!");
    }
});

Console.WriteLine("Print something else after the loop");