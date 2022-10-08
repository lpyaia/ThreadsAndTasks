// T1 is Foreground Thread, T2 is Background Thread
// T2 will still running even after T1 ends. It will only be interrupted if the Main Process exits
var t1 = new Thread(() =>
{
    int count = 0;

    var t2 = new Thread(() =>
    {
        int count = 10;

        while (count < 600)
        {
            Thread.Sleep(1000);
            count += 10;
            Console.WriteLine($"Thread 2 => Count: {count}");
        }

        Console.WriteLine("Thread 2 - END");
    });

    t2.IsBackground = true;
    t2.Start();

    while (count < 10)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Thread 1 => Seconds: {++count}");
    }

    Console.WriteLine("Thread 1 - END");
});

t1.Start();

Console.ReadLine();
Console.WriteLine("Main Application - End");