using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Сортировка пузырьком. Вызов функции.
*/

 namespace Dcoder
 {
   public class Program
   {
     public static int[] Bubble(int[] arr){
       int save;
       for(int i=0;i<arr.Length;i++){
         for(int j=i+1;j<arr.Length;j++){
           if(arr[i]>arr[j]){
             save = arr[i];
             arr[i] = arr[j];
             arr[j] = save;
           }
         }
       }
       Console.WriteLine("Сортировка завершена: ");
       for(int k=0;k<arr.Length;k++){
         Console.WriteLine(arr[k]);
       }
       return arr;
     }
     public static void Main(string[] args)
     {
       Console.WriteLine("Скольчко чисел будем сортироват?\nВведите количество:");
       int n = Convert.ToInt32(Console.ReadLine());
       int[] mas = new int[n];
       Console.WriteLine("Введите {0} элементов массива:", n);
       for(int i=0; i<mas.Length; i++){
         mas[i] = Convert.ToInt32(Console.ReadLine());
       };
       Bubble(mas);
     }
   }
 }
