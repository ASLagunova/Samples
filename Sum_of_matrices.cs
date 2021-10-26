using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
/*
  С помощью подпрограммы заполнить 
  матрицы случайными числами. 
  Написать подпрограмму, вычисляющую 
  сумму двух матриц. Вывести на экран 
  две исходные матрицы и их сумму.
*/


 namespace Dcoder
 {
   public class Program
   {
     public static void display(int [,] matrix, int niii, int njjj){
       for(int i=0; i<niii; i++){
         for(int j=0; j<njjj; j++){
           Console.Write(matrix[i,j] + "  ");
         }
         Console.WriteLine();
       }
     }
     
     public static int[,] summas (int [,] mas, int nii, int njj){
       int[,] exp = new int[nii,njj];
       int[,] result = new int[nii,njj];
       Random random = new Random();
       for(int i=0; i<nii; i++){
         for(int j=0; j<njj; j++){
            exp[i,j] = random.Next(0,9);
         }
       };
       Console.WriteLine("Слагаемый массив:");
       display(exp, nii, njj);
       for(int i=0; i<nii; i++){
         for(int j=0; j<njj; j++){
           result[i,j] = exp[i,j] + mas[i,j];
         }
       };
       return result;
     }
     
     
     public static void Main(string[] args)
     {
       int ni, nj;
       Console.WriteLine("Из скольки элементов будет состоять матрица?");
       Console.WriteLine("Количество строк (i):");
       ni = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Количество столбцов(i):");
       nj = Convert.ToInt32(Console.ReadLine());
       int[,] arr = new int[ni, nj];
       Random rand = new Random ();
       for(int i=0; i<ni; i++){
         for(int j=0; j<nj; j++){
           arr[i,j] = rand.Next(0,10);
         }
       };
       Console.WriteLine("Сгенерированный массив:");
       display(arr, ni, nj);
       
       int[,] save = summas(arr, ni, nj);
       Console.WriteLine("Полученный массив:");
       display(save, ni, nj);
     }
   }
 }
