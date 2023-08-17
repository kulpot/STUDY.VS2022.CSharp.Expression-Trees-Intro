using System;

//ref link:https://www.youtube.com/watch?v=P60pt5xlms0&list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg
//  lambda expression vs compiler converter lambda method

class MainClass
{
    static bool msilLambdaCompilerVersion(int i)
    {
        return i > 5;
    }
    static void Main()
    {
        Func<int, bool> test = i => i > 5;
        Func<int, bool> test2 = msilLambdaCompilerVersion;
        Console.WriteLine(test(3)); // 3 greater than 5 is false
        Console.WriteLine(test(8)); // 8 > 5 is true
        Console.WriteLine(test2(3));
        Console.WriteLine(test2(8));
    }
}