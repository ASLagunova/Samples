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
       int a;
       int b;
       int result;
       string choice = "repeat";
       
       while (choice=="repeat"){
        Console.WriteLine("Введите число a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число b");
        b = Convert.ToInt32(Console.ReadLine());
       
        if (a<=b){
         Console.WriteLine("Квадраты чисел от {0} до числа {1}", a, b);
          while(a <= b){
           result = a*a;
           Console.WriteLine(result);
           a = a + 1; 
          };
        }
        else {
         Console.WriteLine("Ошибка! Число {0} меньше числа {1}", a, b);
        };
        Console.WriteLine("Введите repeat, чтобы повторить программу,\nили exit, чтобы выйти");
        choice = Console.ReadLine();
       }
     }
   }
 }
 