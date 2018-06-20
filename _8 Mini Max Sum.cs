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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr) {
        long[] input = arr;
        Array.Sort(input);
        
        long firstVal = 0;
        long secondVal = 0;
        for(int i = 0; i < 4; i++) {
            firstVal += input[i];   
        }
        for(int i = 1; i < 5; i++) {
            secondVal += input[i];   
        }
        Console.WriteLine($"{firstVal} {secondVal}");
    }

    static void Main(string[] args) {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
        ;
        miniMaxSum(arr);
    }
}