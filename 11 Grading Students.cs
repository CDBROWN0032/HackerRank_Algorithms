using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] gradingStudents(int[] grades) {
            for(int i = 0; i < grades.Length; i++) {
                if(grades[i] >= 38) {
                    if((grades[i]+1)%5 == 0) {
                        grades[i] += 1;
                    }
                    else if((grades[i]+2)%5 == 0) {
                        grades[i] += 2;
                    }
                }
            }
        return grades;
        }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
