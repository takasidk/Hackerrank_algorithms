using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var p=0D;
        var n=0D;
        foreach(int num in arr){
            if(num>0){
                p++;
            }
            else if(num<0){
                n++;
            }
        }
        Console.WriteLine(String.Format("{0:N6}",p/arr.Count));
        Console.WriteLine(String.Format("{0:N6}",n/arr.Count));
        Console.WriteLine(String.Format("{0:N6}",(arr.Count-p-n)/arr.Count));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

