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
     public static void printArray(string[,] array, int k){
        for(int i=0; i<k; i++){
          for(int j=0; j<k; j++){
            Console.Write(array[i,j] + " ");
          }
          Console.WriteLine();
        }
     }
     
     public static int BigIntegerSum(int n)
    {
        int w = n+2;
        int check = 0;
        string [,] mas = new string[w,w];
        int center2 = w/2;
        int a=2;
        int b=1;
        int t=0;
        int m = 7;
        for(int i=0; i<w; i++){
          for(int j=0; j<w; j++){
            mas[i,j] = "x";
          }
        };
   
        for(int i=0; i<w; i++){
          for(int j=0; j<w; j++){
            if(i>0 && i<w-1 && j>0 && j<w-1)
              mas[i,j] = ".";
          }
        };
        
        
        while(t<n){
          while(mas[a,b+2]!="x"){
            mas[a,b] = "x";
            b++;
          };
          while(mas[a+2,b]!="x"){
            mas[a,b] = "x";
            a++;
          };
          while(mas[a,b-2]!="x"){
            mas[a,b] = "x";
            b--;
          };
          while(mas[a-2,b]!="x"){
            mas[a,b] = "x";
            a--;
          };
          t++;
        }
        
        
        while(m<n){
          m = m + 4;
        };
        if(w%2>0)
          if(n==m)
            mas[center2,center2] = "x";
          else 
            mas[a,b] = "x";
            
        for(int i=0; i<w; i++){
          for(int j=0; j<w; j++){
            if(mas[i,j]==".")
              check++;
          }
        };
        
        printArray(mas,w);
        
        return check;
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
