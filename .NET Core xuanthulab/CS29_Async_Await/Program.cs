static void DoSomeThing(int seconds, string mgs, ConsoleColor color)
{

    Console.ForegroundColor = color;
    System.Console.WriteLine($"{mgs,10} . . . Start");
    Console.ResetColor();
    string a = "abc";
    // . . . 
    lock (a)
    {
        //...
    }

    for (int i = 1; i <= seconds; i++)
    {
        lock (Console.Out)
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine($"{mgs,10} {i,2}");
            Console.ResetColor();
        }

        Thread.Sleep(1000);
    }
    lock (Console.Out)
    {
        Console.ForegroundColor = color;
        System.Console.WriteLine($"{mgs} . . . End");
        Console.ResetColor();
    }


}

static async Task Task2()
{
    Task task2 = new Task(
        () =>
        {
            DoSomeThing(10, "T2", ConsoleColor.Green);
        }
    );
    task2.Start();
    // task2.Wait();
    await task2;
    System.Console.WriteLine("T2 da hoan thanh");
    // return task2;
}
static async Task Task3()
{
    Task t3 = new Task(
    (Object ob) =>
    {
        string tentacvu = (string)ob;
        DoSomeThing(3, "T3", ConsoleColor.Yellow);
    }, "T3");
    t3.Start();
    // t3.Wait();
    await t3;
    System.Console.WriteLine("t3 da hoan thanh");
    // return t3;
}
static async Task<string> Task4()
{
    Task<string> t4 = new Task<string>(() =>
    {
        DoSomeThing(10, "T4", ConsoleColor.Green);
        return "return from t4";
    });
    t4.Start();
    var kq = await t4;
    System.Console.WriteLine("T4 finished");
    return kq;
}
static async Task<string> Task5()
{
    Task<string> t5 = new Task<string>((object ob) =>
    {
        string t = (string)ob;
        DoSomeThing(4, t, ConsoleColor.Yellow);
        return $"Return from {t}";
    }, "T5");
    t5.Start();
    string kq = await t5;
    System.Console.WriteLine("t5 is finished!");
    return kq;
}

//asynchronous (multi thread)
Console.Clear();

Task<string> t4 = Task4();
Task<string> t5 = Task5();


// syncchronous

DoSomeThing(2, "T1", ConsoleColor.Magenta); // Thread
Task.WaitAll(t4, t5);
var kq4 = t4.Result;
var kq5 = t5.Result;
System.Console.WriteLine(kq4);
System.Console.WriteLine(kq5);
System.Console.WriteLine("xin chao cac ban");
System.Console.WriteLine("Press any key");
Console.ReadKey();