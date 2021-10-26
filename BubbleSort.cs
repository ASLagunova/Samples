using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

 namespace Dcoder
 {
   public class Program
   {
     public static void swap(int el1, int el2){
       int save = 0;
       el1 = save; 
       el1 = el2; 
       el2 = save;
     }
     
     public static int[] BubbleSort(int[] array){
       int save = 0;
       for(int i=0; i<array.Length; i++){
         for(int j=0; j<array.Length-1-i; j++){
           if(array[j]>array[j+1]){
             save = array[j]; 
             array[j] = array[j+1]; 
             array[j+1] = save;
             for(int k=0; k<array.Length; k++){
               Console.Write(array[k] + " ");
              };
             Console.WriteLine();
           }
            // swap(array[i], array[j]);
         }
       }
       for(int i=0; i<array.Length; i++){
         //Console.Write(array[i] + " ");
       };
       return array;
     }
     
     public static void Main(string[] args)
     {
       int[] mas = {5,1,9,0};
       int[] result = BubbleSort(mas);
       foreach(int el in result){
         //Console.Write(el + " ");
       }
       for(int i=0; i<result.Length; i++){
         //Console.Write(result[i] + " ");
       }
     }
   }
 }
