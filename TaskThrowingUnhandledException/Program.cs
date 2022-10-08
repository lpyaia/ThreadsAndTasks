// When a Task without await throws an unhandled exception, the main process won't quit

CountAsync();

Console.ReadLine();
Console.WriteLine("End");

async Task CountAsync()
{
    int count = 0;

    while (count < 60)
    {
        await Task.Delay(1000);
        Console.WriteLine($"Seconds: {++count}");

        if (count == 6)
            throw new Exception("Thread throws an exception!");
    }
}