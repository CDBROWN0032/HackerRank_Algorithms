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

    // Complete the staircase function below.
    static void staircase(int n) {
        string[] stairs = new string[n + 1];
        string input = "";
        int counter = 0;
        for(int i = 0; i < stairs.Length - 1; i++) {             
            do {
            input += " ";    
            counter = input.Length;
             } while (counter != n - i);
            for(int j = n; j > counter; j--) {
            input += "#";
            }
            stairs[i] = input;
            input = "";
        } 
        for(int i = 0; i < n; i++) {
            input += "#";
        }
        stairs[n] = input;
        stairs = stairs.Skip(1).ToArray();
        foreach(string line in stairs) {
        Console.WriteLine($"{line}");
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
