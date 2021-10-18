using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5
//

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      double x = 30f;
      double y;
      if(x>15f){
        y=Math.Sin(x);
        
      }
      else {
        y=Math.Cos(x);
      };
      Console.WriteLine(y);
       }
     }
   }
 
 
