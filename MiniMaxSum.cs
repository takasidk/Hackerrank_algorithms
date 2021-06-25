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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        var mini=long.MaxValue;
        var maxi=long.MinValue;
        var totalSum=0L;
        foreach(int num in arr){
            totalSum+=num;
        }
        for(int i=0;i<arr.Count;++i){
            if(totalSum-arr[i]>maxi){
                maxi=totalSum-arr[i];
            }
            if(totalSum-arr[i]<mini){
                mini=totalSum-arr[i];
            }
        }
        Console.WriteLine(mini+" "+maxi);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

