using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Link:https://www.hackerrank.com/challenges/extra-long-factorials/problem
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void extraLongFactorials(int n)
    {
        BigInteger fact=1L;
        for(int i=1;i<=n;i++){      
        fact=fact*i;      
        }   
        Console.WriteLine(fact);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}
