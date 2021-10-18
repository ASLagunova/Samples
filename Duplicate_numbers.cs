using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/* 
  Есть ли в массиве одинаковые элементы?
*/

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] mas = new int[8];
       int[] arr = new int[8];
       Random rand = new Random();
       for(int i=0; i<mas.Length; i++){
         mas[i] = rand.Next(0,10);
         arr[i] = -1;
         Console.WriteLine(mas[i]);
       };
       for(int i=0; i<mas.Length; i++){
         for(int j=i; j<mas.Length-1; j++){
           if(mas[i]==mas[j+1]){
             arr[i] = mas[i];
             //Console.WriteLine("Одинаковые числа: " + mas[j]);
           };
         }
       }
      for(int i=0; i<mas.Length; i++){
        if(arr[i]>=0)
          Console.WriteLine("Повторяющееся число: " + arr[i]);
      }
     }
   }
 }
