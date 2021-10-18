using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

/*Заменить все элементы массива 
на противоположные по знаку.

Найти сумму четных отрицательных 
элелементов массива

Вывести элементы массива, которые 
больше среднего арифметического

Вывести количество и сумму элементов 
массива,принадлежащих интервалу

Вывести в порядке возрастания цифры,
из которых состоит число*/
  

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       float[] mas = {512, 42, -10, 0, -15, -43, 84};
       float chek;
       float sum1=0;
       float sum2=0;
       float arifm = 0;
       float p;
       float sum3=0;
       float kolvo=0;
       //Console.WriteLine(mas[2]);
       
/*     for(int i=0; i<mas.Length; i++){
         mas[i] = mas[i]*(-1);
         Console.WriteLine(mas[i]);
       };
*/
/*
       for(int i=0; i<mas.Length; i++){
        chek = mas[i]%2;
        if(chek==0 && mas[i]<0){
          sum1 = sum1 + mas[i];
        };
       };
      Console.WriteLine(sum);
*/
/*
    for(int i=0; i<mas.Length; i++){
        sum2 = sum2 + mas[i];
        p = mas.Length;
        arifm = sum2/p;
        if(mas[i]>arifm)
         Console.WriteLine(mas[i]);
      }
*/
/*
   for(int i=0; i<mas.Length; i++){
     if(mas[i]>0 && mas[i]<5){
       kolvo++;
       sum3 = sum3 + mas[i];
     }
   };
    Console.WriteLine("Количество: {0}\nСумма: {1}", kolvo, sum3);
*/
int[] arr =  {512, 42, -10, 212, -15, -463, 841, 219, 703};
int sot=0;
int des=0;
int edn=0;
int save;
int[] chisla = new int[3]{sot, des, edn};
 for(int i=0; i<arr.Length; i++){
   if(arr[i]<0){
     arr[i] = -1*arr[i];
   };
   if(arr[i]>99){
     sot=arr[i]/100;
     des=(arr[i]-sot*100)/10;
     edn=(arr[i]-sot*100)%10;
     //Console.WriteLine("{0}, {1}, {2}", sot, des, edn);
     chisla[0] = sot;
     chisla[1] = des;
     chisla[2] = edn;
   }
   else if (arr[i]>9 && arr[i]<100){
     des = arr[i]/10;
     edn = arr[i]%10;
     //Console.WriteLine("{0}, {1}", des, edn);
     chisla[0] = 0;
     chisla[1] = des;
     chisla[2] = edn;
   }
   else {
     edn = arr[i];
     chisla[0] = 0;
     chisla[1] = 0;
     chisla[2] = edn;
     //Console.WriteLine("{0}", edn);
   };
  //Console.WriteLine("{0}, {1}, {2}", chisla[0], chisla[1], chisla[2]);
   
   for(int k=1; k<=2; k++){
    for(int y=1; y<=2; y++){
      save = chisla[y];
      if(chisla[y-1]>chisla[y]){
        chisla[y] = chisla[y-1];
        chisla[y-1] = save; 
      };
     // Console.WriteLine("{0}, {1}, {2}", chisla[0], chisla[1], chisla[2]);
    }
   }
    Console.WriteLine("{0}, {1}, {2}", chisla[0], chisla[1], chisla[2]);
 }
 }
 }
 }
 
