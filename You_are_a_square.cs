using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Является ли число квадратом целого 
  числа?
*/


 namespace Dcoder
 {
   public class Program
   {
     
     public static bool IsSquare(int n){
       bool res = true;
       double p = Math.Sqrt(n);
       if((n%p == 0) || (n == 0) )
         res = true;
       else
         res = false;
        
       return res;
     } 
     
     public static void Main(string[] args)
     {
       Console.WriteLine("Введите число:");
       int number;
       number = Convert.ToInt32(Console.ReadLine());
       bool result = IsSquare(number);
       Console.WriteLine("Результат: " + result);
     }
   }
 }
