﻿using System;
namespace ExtensionMethods
{
    class program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            string y = " hello";

            Console.WriteLine(x + " is capitalized?" + x.IsCap());
            Console.WriteLine(y + " is capitalized?" + y.IsCap());
        }

    }
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if(string.IsNullOrEmpty(s))return false;
            return char.IsUpper(s[0]); 
        }
    }
}