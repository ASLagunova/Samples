using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  Напишите функцию, которая принимает 
  массив из 10 целых чисел (от 0 до 9),
  который возвращает строку этих чисел 
  в форме номера телефона.
*/


 namespace Dcoder
 {
   public class Program
   {
     public static string CreatePhoneNumbers(int[] numbers){
       //  string phone_numbers = String.Concat<int>(numbers);
       /*StringBuilder phone_numbers = new StringBuilder(numbers.Length);
       foreach (char el in numbers)
        {
          phone_numbers.Append(el);
        }
        string value = phone_numbers.ToString();
       */
       string lscob = "(";
       string rscob = ")";
       string space = " ";
       string dash = "-";
       
       string phone_numbers = "";
       for(int i=0; i<numbers.Length; i++){
         phone_numbers = phone_numbers.Insert(i, numbers[i].ToString());
       }
       
       phone_numbers = phone_numbers.Insert(0, lscob);
       phone_numbers = phone_numbers.Insert(4, rscob);
       phone_numbers = phone_numbers.Insert(5, space);
       phone_numbers = phone_numbers.Insert(9, dash);
       return phone_numbers;
     }
     
     public static void Main(string[] args)
     {
       int[] array = new int[10];
       Random rand = new Random();
       for(int i=0; i<array.Length; i++){
         array[i] = rand.Next(0,9);
        // Console.Write(array[i] + " ");
       }
       string number = CreatePhoneNumbers(array);
       Console.WriteLine(number);
     }
   }
 }
