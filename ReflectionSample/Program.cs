using Microsoft.Win32.SafeHandles;
using System.Diagnostics;

namespace ReflectionSample;

public class Program
{
    static void Main(string[] args)
    {
        var person = LoadDataLogic.CreatePerson();
        Stopwatch sw = Stopwatch.StartNew();
        Console.WriteLine(ReflectionLogic.GetProperties(person));
        sw.Stop();
        Console.WriteLine(sw.Elapsed.TotalMilliseconds);
        Console.ReadLine();
    }
}
