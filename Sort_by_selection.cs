using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Сортировка выбором. Требуется 
  отсортировать массив по возрастанию.
  
  Последовательно производится поиск 
  наименьшего значения, которое 
  перемещается на первую позицию. 
  Затем в поиск в оставшейся части 
  для второй позиции, и т.д. до 
  завершения массива.
*/


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] arr = new int[5];
       int min = arr[0];
       int save;
       int chek=0;
       Random rand = new Random ();
       Console.WriteLine("До сортировки:");
       for(int t=0; t<arr.Length; t++){
         arr[t] = rand.Next(0,10);
         Console.WriteLine(arr[t]);
       };
       for(int i=0; i<arr.Length; i++){
          min = arr[i];
/*
          Console.WriteLine("Новая итерация");
          for(int k=0; k<5; k++){
            Console.WriteLine(arr[k]);
          };
          Console.WriteLine("min: " + min);
*/
          for(int j=i; j<arr.Length; j++){
             if(arr[j]<min){
               min = arr[j];
               chek = j;
             };
            //Console.WriteLine("arr: {0}, min: {1}, chek: {2}", j, min, chek);
          };
          if(arr[i]!=min){
            save = arr[i];
            arr[i] = min;
            arr[chek] = save;
          }
       };
       Console.WriteLine("После сортировки:");
       for(int i=0; i<arr.Length; i++){
         Console.WriteLine(arr[i]);
       }
     }
   }
 }
