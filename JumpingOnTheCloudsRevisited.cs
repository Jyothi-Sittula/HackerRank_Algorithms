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
/*  https://www.hackerrank.com/challenges/jumping-on-the-clouds-revisited/problem   */
class Solution {

    static int jumpingOnClouds(int[] c, int k) {
        
        var energy = 100;
        var i=(0+k)%c.Length;
        energy -= (c[i]*2 + 1);
        while(i!=0)
        {
            i=(i+k)%c.Length;
            energy -= (c[i]*2 + 1);
        }
        return energy;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
