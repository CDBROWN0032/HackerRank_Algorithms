using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {

        s = s.Replace("PM", ":PM").Replace("AM", ":AM");
        string convertedTime = "";
        string[] time = s.Split(':');
        if (time[0] == "12" && time[3] == "AM") {
                time[0] = "00";
        }
        else if (time[0] == "12" && time[3] == "PM") {
        }
        else if(time[3] == "PM") {
            Int32.TryParse(time[0], out int x);
            x += 12;
            if (x == 12 && time[3] == "AM") {
                x = 00;
            }
            else if (x == 24) {
                x = 00;
            }
            else if (x > 24) {
                x -= 12;
            }
            time[0] = x.ToString();
        }
        for(int i = 0; i < 3; i++) {
            convertedTime += time[i];
            if (i < 2) {
                convertedTime += ":";
            }
            
        }
        return convertedTime;
        }

    

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
