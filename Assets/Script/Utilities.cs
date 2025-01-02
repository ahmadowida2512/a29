using System.Linq;
using UnityEngine;

public  static class Utilities
{
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
      public static string RepeatString(this string str, int times)
    {
        if (times <= 0) return "";

    for (int i = 0; i < times; i++)
    {
        str+= str;
        
    }
    return str;
    }
    
}
