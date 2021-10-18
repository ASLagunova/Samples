using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Sashka
 {
   public class Program                           
   {
     public static void Main(string[] args)
     {
      int first = 4, second = 5;
      
       Console.WriteLine("Первое: " + first + "; " + "Второе: " + second);
      int third = 0;
      third = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Третье: " + third);
      int result;
      result = first + second + third;
      Console.WriteLine("Результат: " + result);
     }
   }
 }
