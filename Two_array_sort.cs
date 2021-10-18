using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
   Даны два массива с различным 
   количеством элементов. 
   Перераспределить их элементы так, 
   чтобы в первом массиве были 
   наименьшие из двух массивов, 
   а во втором - наибольшие.
*/
   


 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       int[] mas = new int[5];
       int[] arr = new int[3];
       int[] prob = new int[mas.Length + arr.Length];
       int j = 0;
       int f=0;
       int save=0;
       Random rand = new Random();
       
//Заполняю массивы
       for(int i=0; i<prob.Length; i++){
         if(i<mas.Length){
            mas[i] = rand.Next(0,10);
            prob[i] = mas[i];
            Console.WriteLine("mas: " + mas[i]);
         }
         else {
             arr[j] = rand.Next(0,10);
             prob[i] = arr[j];
             Console.WriteLine("arr: " + arr[j]);
             j++;
           }
       };
       for(int i=0; i<prob.Length; i++){
          //Console.WriteLine("prob: " + prob[i]);
       };
       
//Сортирую элементы в полученном массиве по возрастанию
       for(int i=0; i<prob.Length; i++){
         for(int k=0; k<prob.Length-1; k++){
           if(prob[k+1]<prob[k]){
             save = prob[k];
             prob[k] = prob[k+1];
             prob[k+1] = save;
           }
         }
       }
       for(int i=0; i<prob.Length; i++){
          //Console.WriteLine("prob sort: " + prob[i]);
       };
       
//Заполняю первые два массива повозрастанию элементов
       for(int i=0; i<prob.Length; i++){
         if(i<mas.Length){
            mas[i] = prob[i];
            Console.WriteLine("mas sort: " + mas[i]);
         }
         else {
             arr[f] = prob[i];
             Console.WriteLine("arr sort: " + arr[f]);
             f++;
           }
       };
       
     }
   }
 }
 
 
