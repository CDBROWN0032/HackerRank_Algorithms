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

    static int diagonalDifference(int[][] arr) {
        int endPoint = arr.Length;
        int[] dDown = new int[endPoint];
        int[] dUp = new int[endPoint];
        int j = 0;

        for(int i = 0; i < endPoint; i++) {
            dDown[i] = arr[i][j];
            dUp[i] = arr[endPoint - (i+1)][j++];
            Console.Error.WriteLine(dUp[i]);
                
        }
        int dDownValue = 0;
        int dUpValue = 0;
        int absoluteDifference = 0;
        for(int i = 0; i < dDown.Length; i++) {
            dDownValue += dDown[i];
            
        }
        for(int i = 0; i <dUp.Length; i++) {
            dUpValue += dUp[i];

        }
        absoluteDifference = Math.Abs(dDownValue - dUpValue);
        return absoluteDifference;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
