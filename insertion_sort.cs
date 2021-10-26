using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Сортировка вставками


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] arr = {9,11,0,4};
       int save;
       int j;
       for(int i=0; i<arr.Length; i++){
         save = arr[i];
         j=i;
         while(j>0 && arr[j-1]>save){
           arr[j] = arr[j-1];
           j--;
         /*  for(int k=0; k<arr.Length; k++){
             Console.Write(arr[k] + " ");
           }
           Console.WriteLine();    */
         }
         arr[j] = save;
        /* for(int k=0; k<arr.Length; k++){
           Console.Write(arr[k] + " ");
         }
         Console.WriteLine();      */   
       };
       
       for(int i=0; i<arr.Length; i++){
          Console.WriteLine(arr[i]);
       }
     }
   }
 }
