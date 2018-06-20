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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
    float baseValue = arr.Length;
    float positive = 0;
    float negative = 0;
    float zeroVal = 0;

    for(int i = 0; i < baseValue;i++ ) {
        if(arr[i] == 0){
            zeroVal++;
        }
        else if(arr[i] > 0) {
            positive++;
        }
        else if(arr[i] < 0) {
            negative++;
        }
    }
    positive /= baseValue;
    negative /= baseValue;
    zeroVal /= baseValue;
        
    Console.WriteLine(positive);
    Console.WriteLine(negative);
    Console.WriteLine(zeroVal);
    

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
