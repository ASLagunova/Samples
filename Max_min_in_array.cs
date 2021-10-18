using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

/*Разделить элесенты массива 
на максимальный*/
  
 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] mas = new int[4];
       int max;
       int min;
       int result;
       Console.WriteLine("4 рандомных чисела в массиве");
       Random x = new Random(); 
       for(int i = 0; i<mas.Length; i++){
           mas[i] = Convert.ToInt32(x.Next(-10,10));
           Console.WriteLine(mas[i]);
           };
       max = mas[0];
       min = mas[0];
       for (int j = 0; j<mas.Length-1; j++) {
        for(int i = 0; i<mas.Length-1; i++){
            if(mas[i+1]>mas[i] && mas[i+1]>max)
              max = mas[i+1];
            if(mas[i+1]<mas[i] && mas[i+1]<min)
              min = mas[i+1];
       };
     };
     
      Console.WriteLine("Максимальное число: " + max);
      Console.WriteLine("Минимальное число: " + min);
      for(int i = 0; i<mas.Length; i++){
           result = mas[i]/max;
          // Console.WriteLine(result);
           };
   }
 }
 }
