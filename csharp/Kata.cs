using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Kata
{
    public static int stringCounter(string inputS, string charS)
    {
        return Regex.Matches(inputS, Regex.Escape(charS)).Count;
    }
}

