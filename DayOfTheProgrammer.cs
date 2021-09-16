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
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */
    public static string dayOfProgrammer(int year)
    {
        int days;    // number of feb days
        
        if(year<1918){    //jordian calendar
            //leap year
            if(year%4==0){
                days=29;
            }
            //Not leap year
            else days=28;
        }
        
        else if(year>1918){    //gregorian calendar
            //Not leap
            if(year%4!=0){
                days=28;
            }
            //leap
            else if(year%100!=0){
                days=29;
            }
            //not leap
            else if(year%400!=0){
                days=28;
            }
            //leap
            else{
                days=29;
            }
        }
        
        else days=15;    //when year=1918
        
        days=256-(days+215);
        return (days).ToString()+".09."+year.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}