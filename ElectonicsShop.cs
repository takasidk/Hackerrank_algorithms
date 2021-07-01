using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Link:https://www.hackerrank.com/challenges/electronics-shop/problem
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b,int n,int m) {
        keyboards=keyboards.OrderByDescending(c=>c).ToArray();  //descending order
        drives=drives.OrderBy(c=>c).ToArray();  //Ascending order
        var max=-1;
        for(int i=0;i<n;++i){
            for(int j=0;j<m;++j){
                if(keyboards[i]+drives[j] > b)
                    break;
                if(keyboards[i]+drives[j] > max)
                    max = keyboards[i]+drives[j];
            }
        }
        return max;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b,n,m);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}