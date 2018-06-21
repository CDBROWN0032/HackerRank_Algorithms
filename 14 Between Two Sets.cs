using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
   static int getTotalX(int[] a, int[] b) {
        int total = 0;
        int aMax = a.Max();
        int bMin = b.Min();
        int counter = 1;
        int multiples = aMax;

        while (multiples <= bMin) {
            bool isFactor = true;

            foreach (var item in a) {
                if (multiples % item != 0) {
                    isFactor = false;
                    break;  
                }
            }

            if (isFactor) {
                foreach (var item in b) {
                    if (item % multiples != 0) {
                        isFactor = false;
                        break;
                    }
                }
            }

            if (isFactor) 
                total++;
            

            counter++;
            multiples = aMax * counter;
        }
        return total;
    }
   


    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
