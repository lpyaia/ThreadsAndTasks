// Foreground Thread for Default => Makes the main application wait for the end of this thread
var t1 = new Thread(() =>
{
    int count = 0;

    while (count < 60)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Seconds: {++count}");
    }
});

t1.Start();

Console.WriteLine("End");