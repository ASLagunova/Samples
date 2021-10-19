using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
// Функции, считающие сумму, гипотенузу

 namespace Dcoder
 {
   public class Program
   {
     public static void print(string words){
      Console.WriteLine(words);  
     }
     public static int summ(int a, int b){
       int res = a + b;
       print("Результат:");
       print(res.ToString());
       return res;
     }
     public static void hypotenuse(int a, int b){
       double h = Math.Sqrt(a*a + b*b);
       print("Гипотенуза равна:");
       print(h.ToString());
     }
      
     public static void Main(string[] args)
     {
       print("Введите число а");
       int x = Convert.ToInt32(Console.ReadLine());
       print("Введите число b");
       int y = Convert.ToInt32(Console.ReadLine());
       hypotenuse(x,y);
     }
   }
 }
