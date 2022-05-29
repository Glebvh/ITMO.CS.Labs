using System;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Enter string to reverse: ");
        string x = Console.ReadLine();
        ITMO.CS.Labs.LabSevenTwo.Utils.Reverse(ref x);
        Console.WriteLine(x);
    }
}
