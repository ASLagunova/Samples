using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Возвращает количество гласных 
  в заданной строке.
*/

 namespace Dcoder
 {
   public class Program
   {
     public static int GetVowelCount(string str)
    {
       int vowelCount = 0;
       bool g = false;
       char[] arr = {'a', 'e', 'i', 'o', 'u', 'y'};
       for(int i = 0; i<str.Length;i++){
         for(int j = 0; j<arr.Length;j++){
           if(str[i] == arr [j]){
           vowelCount++;
           }
         }
       };
       
       return vowelCount;
    }
    
     public static void Main(string[] args)
     {
       Console.WriteLine("Введите строку: ");
       string str = Console.ReadLine();
       int number = GetVowelCount(str);
       Console.WriteLine(number);
     }
   }
 }
