
﻿using String;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StringUtils.ToUpper("connall"));
        Console.WriteLine(StringUtils.ToLower("CONNALL"));
        Console.WriteLine(StringUtils.Length("Connall"));
        Console.WriteLine(StringUtils.Reverse("Connall"));
        Console.WriteLine(StringUtils.CountVowels("Connall"));
        Console.WriteLine(StringUtils.CountConsonants("Connall"));
        Console.WriteLine(StringUtils.HasLetter("Connall", 'e'));
        Console.WriteLine(StringUtils.CapsfirstLetter("connall"));
        Console.WriteLine(StringUtils.CapslastLetter("connall"));
        Console.WriteLine(StringUtils.IsPalindrome("Racecar"));
        Console.WriteLine(StringUtils.StringRemoveSpaces("C o n na l l"));
    }
}