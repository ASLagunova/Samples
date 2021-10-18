using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int a = 10;
       float b = 10.4f;
       for( int i=0; i<=15; i++){
        Console.WriteLine("{0} {1}", a, b);
        a += 1;
        b = b + 1;
       };
     }
   }
 }
