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
    
    public static int migratoryBirds(List<int> arr)
    {
        var res=arr[0];
        var prev=arr[0];
        var Rcount=1;
        var Ccount=1;
        arr.Sort();
        for(int i=1;i<arr.Count;++i){
            if(arr[i]==prev){
                Rcount++;
            }
            else{
                Rcount=1;
                prev=arr[i];
            }
            if(Ccount<Rcount){
                res=arr[i];
                Ccount=Rcount;
            } 
        }
        return res;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
