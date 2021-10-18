using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Число совершенно, если оно равно 
  сумме всех своих делителей, кроме 
  самого себя. Пример: 6=1+2+3. 
  Найдите все совершенные числа 
  от 1 до 100 и выведите их на экран. 
*/


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      List<int> numbers = new List<int> ();
      int chek=0;
      int p=0;
      int d=0;
     
      for(int i=1;i<=10000;i++){
         for(int j=1;j<i;j++){
            if(i%j==0){
              chek = chek + j;
              
              if(i==24){
                d=d+j;
                //Console.WriteLine(chek);
              };
              if(i==2016){
                p=p+j;
              };
              //Console.WriteLine("d: {0}, p: {1}", d, p);
              //Console.WriteLine("chek: " + chek);
              //Console.WriteLine("i: {0},  j: {1},  mod: {2}", i, j, i%j);
            }
         };
         if(i==chek){
                numbers.Add(i);
              };
         chek = 0;
      };

        foreach(int el in numbers){
          Console.WriteLine("лист: " + el);
        }
     }
   }
 }
 
