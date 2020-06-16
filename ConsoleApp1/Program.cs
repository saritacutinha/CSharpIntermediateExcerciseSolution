using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        List<string> strList = new List<string>() { "sample1", "sample2", "sample3" };
        Console.WriteLine("Original list:\n" + string.Join(", ", strList));
        ModifyList(strList);
        Console.WriteLine("Modified List:\n" + string.Join(", ", strList));
    }

    private static void ModifyList(List<string> list)
    {
        list.Add("new sample");
        Console.WriteLine("After Modification:\n" + string.Join(", ", list));
    }
}