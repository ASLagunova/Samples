using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Функция находит дискриминант и 
  корни квадратного уравнения
*/
  
 namespace Dcoder
 {
   public class Program
   {
     public static void print(string words){
       Console.WriteLine(words);
     }
     public static void disc(int a, int b, int c){
       Console.WriteLine("Квадратное уравнение: {0}*x^2 + {1}*x + {2}", a, b, c);
       int D = b*b - 4*a*c;
       print("Дискриминант равен:");
       print(D.ToString());
       if(D<0){
         print("Уравнение не имеет корней");
       }
       else if(D==0){
         print("Уравнение имеет один корень:");
         int root = -1*b/(2*a);
         print(root.ToString());
       }
       else
         print("Управнение имеет два корня:");
         double root1 = (-1*b + Math.Sqrt(D))/(2*a);
         double root2 = (-1*b - Math.Sqrt(D))/(2*a);
         print(root1.ToString());
         print(root2.ToString());
     }
     
     public static void Main(string[] args)
     {
       print("Введите а");
       int a = Convert.ToInt32(Console.ReadLine());
       print("Введите b");
       int b = Convert.ToInt32(Console.ReadLine());
       print("Введите c");
       int c = Convert.ToInt32(Console.ReadLine());
       disc(a, b, c);
       disc(2, 9, 4);
     }
   }
 }
