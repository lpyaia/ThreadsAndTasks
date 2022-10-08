// When a Foreground Thread throws a handled exception, the main process won't quit
var t1 = new Thread(() =>
{
    try
    {
        int count = 0;

        while (count < 60)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Seconds: {++count}");

            if (count == 6)
                throw new Exception("Thread throws an exception!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
});

t1.Start();

Console.ReadLine();
Console.WriteLine("End");