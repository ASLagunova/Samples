using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static string RepeatStr(int n, string s)
    {
      string res = "";
      for(int i=1; i<=n; i++){
        res = res + s;
      }
      return res;
    }
     public static void Main(string[] args)
     {
       string h = "ha ";
       string enter = RepeatStr(2,h);
       Console.WriteLine(enter);
     }
   }
 }
