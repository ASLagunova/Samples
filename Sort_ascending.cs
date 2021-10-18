using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] mas = new int[4];
       int input;
       int save;
       
       Console.WriteLine("Введите числа массива:");
       for(int a=0; a<mas.Length; a++){
        input = Convert.ToInt32(Console.ReadLine());
        mas[a] = input;
       };
       
      for(int j =1; j<mas.Length; j++){ 
       for(int i = 1; i<mas.Length; i++){
           if(mas[i-1]>mas[i]){
             save = mas[i];
             mas[i] = mas[i-1];
             mas[i-1] = save;
           }
           else {
             save = mas[i-1];
           };
          };     
     };
     Console.WriteLine("Отсортированные по возрастанию числа массива:");
     for(int f=0; f<mas.Length; f++){
       Console.WriteLine(mas[f]);
     };
     
   }
   
 }
 }
