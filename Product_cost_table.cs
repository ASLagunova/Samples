using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5
/*
Одна штука некоторого товара стоит 
55,99 руб. Напечатать таблицу стоимости
2, 3, …, 20 штук этого товара.
*/
 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       
       Console.WriteLine("Таблица стоимости товара");
       float tovar = 55.99f;
       float price = 0;
       byte number = 0;
       Console.WriteLine("Количество  Цена");
       for(int i=1; i<=20; i++) {
         price = price + tovar;
         number += 1;
         Console.WriteLine("{0}           {1}", number, price);
       }
       
     }
   }
 }
