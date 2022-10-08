// Background Thread => Immediatly ends after main process ends
var t1 = new Thread(() =>
{
    int count = 0;

    while (count < 60)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Seconds: {++count}");
    }
});

t1.IsBackground = true;
t1.Start();

Thread.Sleep(5000);

Console.WriteLine("End");