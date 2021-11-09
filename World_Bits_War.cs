using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Война четных и нечетных чисел. 
  Сила числа определяется количеством 
  установленных битов 1 в его двоичном 
 
  представлении. Отрицательные целые 
  числа работают против самих себя, 
  поэтому их сила отрицательна.
  Побеждает сторона с наибольшей 
  совокупной силой.
*/

 namespace Dcoder
 {
   public class Program
   {
     public static string BitsWar(List<int> numbers)
     { 
       Console.WriteLine();
// Переводим числа из 10 системы счисления в 2
      List<int> bits = new List<int>(0);
      int temp;
      int sum;
      int sum_chet = 0;
      int sum_nechet = 0;
    
      for(int i=0; i<numbers.Count; i++){
        sum = 0;
        temp = numbers[i];
          while(temp>=1 || temp<0){
            bits.Add(temp%2);
            temp = temp/2;
          }
          
        Console.WriteLine("Число {0} превратиться в: ", numbers[i]);
        foreach(int el in bits){
          Console.Write(el + " ");
          sum = sum + el;
        }
        
        if(numbers[i]%2==0)
          sum_chet = sum_chet + sum;
        else
          sum_nechet = sum_nechet + sum;
        
        while(bits.Count>0)
          bits.RemoveAt(0);
      }
      Console.WriteLine("Сумма четных: " + sum_chet);
      Console.WriteLine("Сумма нечетных: " + sum_nechet);
      string result = "";
      if(sum_nechet > sum_chet)
        result = "odds win";
      else if(sum_nechet < sum_chet)
        result = "evens win";
      else
        result = "tie";
        
      return result;
     }


     public static void Main(string[] args)
     {
       List<int> numbers = new List<int>(0);
       int element;
       int check = 0;
       int stop;
      
       Console.WriteLine("Сколько элементов будут воевать?");
       stop = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите элементы: ");
       
       for(int i=0; i<stop; i++){
         element = Convert.ToInt32(Console.ReadLine());
         numbers.Add(element);
         check++;
       };
       Console.WriteLine("Готовы к войне: ");
       foreach(int el in numbers)
         Console.Write(el + " ");
       Console.WriteLine();
       string result = BitsWar(numbers);
       Console.WriteLine(result);
     }
   }
 }
