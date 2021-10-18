using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
   Найти сумму элементов массива.
   Найти максимальное значение в массиве.
*/
   
 

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] mas = new int[5];
       Random rand = new Random();
       int sum=0;
       int chek=-5;
       for(int i=0; i<mas.Length; i++){
         mas[i] = rand.Next(-5,5);
       };
       foreach(int id in mas){
         Console.WriteLine(id);
         sum=sum+id;
         if(id>chek){
           chek=id;
         }
       };
       //Console.WriteLine("Сумма: " + sum);
       //Console.WriteLine("Максимум: " + chek);
     }
   }
 }
