using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Вернуть количество пробелов (точек)
  в спирали NxN.   
*/

 namespace Dcoder
 {
   public class Program
   {
     
     public static int BigIntegerSum(int n)
       {
        int k1 = 1;
        int k2 = n;
        int sum1 = 0;
        int sum2 = 0;
        int sum = 0;
        for(int i=1; i<=n; i++){
         if(i%2==0){
           k1++;           
           sum1 = sum1 + k1;
         }
         else{
           sum2 = sum2 + k2;
         //Console.WriteLine("k2: " + k2);
           k2--;
         }
        }
        if(n%2==0)
          sum = sum1 + sum2 - 1;
        else
          sum = sum1 + sum2;
          
        return sum;
       }

     public static void Main(string[] args)
     {
       Console.WriteLine("Введите размер спирали: ");       
       int size = Convert.ToInt32(Console.ReadLine());
       int result = BigIntegerSum(size);
       Console.WriteLine("Количество пробелов: " + result);
        
     }
   }
 }
