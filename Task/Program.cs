// A Task without await will immediately ends after main process ends

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
    }
}