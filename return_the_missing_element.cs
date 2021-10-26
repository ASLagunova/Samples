using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Вернуть элемент, которого не хватает 
  в массиве, состоящего из элементов
  от 0 до 9.
*/
 namespace Dcoder
 {
   public class Program
   {
     public static int GetMissingElement(int[] superImportantArray)
     {
       int chek = superImportantArray[0]; 
       int save = 0;
       for(int i=0; i<superImportantArray.Length; i++){
         for(int j=i; j<superImportantArray.Length; j++){
           //chek =superImportantArray[i] - superImportantArray[j];
           // Console.WriteLine("Итерация i={0}, j={1}, arri={2}, arrj={3}", i, j, superImportantArray[i], superImportantArray[j]);
           if(superImportantArray[i] > superImportantArray[j]){
             save = superImportantArray[i];
             superImportantArray[i] = superImportantArray[j];
             superImportantArray[j] = save;
           } 
         }
       };
       for(int i=0; i<superImportantArray.Length-1; i++){
           if(superImportantArray[i+1] == (superImportantArray[i] + 2)){
             chek = superImportantArray[i] + 1;
           }
       }
       return chek;
     }
     
     
     public static void Main(string[] args)
     {
       int[] arr = {9, 2, 4, 5, 7, 0, 8, 6, 1};
       int el = GetMissingElement(arr);
       Console.WriteLine(el);
     }
   }
 }
