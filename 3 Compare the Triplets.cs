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

class Solution {

    // Complete the solve function below.
    static int[] solve(int[] a, int[] b) {
        int aliceScore = 0;
        int bobScore = 0;
        for(int i = 0; i < a.Length; i++){
            if (a[i] == b[i]) {

            }
            else if (a[i] > b[i]) {
                aliceScore += 1;
            }
            if (a[i] < b[i]) {
                bobScore += 1;
            }
        }
        int[] finalScore = new int[] {aliceScore, bobScore};
        return finalScore;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int[] result = solve(a, b);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
