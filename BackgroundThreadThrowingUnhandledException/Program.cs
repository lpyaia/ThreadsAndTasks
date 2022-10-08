// When a Background Thread throws an unhandled exception, the main process will quit
var t1 = new Thread(() =>
{
    int count = 0;

    while (count < 60)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Seconds: {++count}");

        if (count == 6)
            throw new Exception("Thread throws an exception!");
    }
});

t1.IsBackground = true;
t1.Start();

Console.ReadLine();
Console.WriteLine("End");