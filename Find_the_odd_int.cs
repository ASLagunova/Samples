using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution
{
  class Kata
   {
    public static int find_it(int[] seq) 
      {
        int chek = 0;
        int save = 0;
      for(int i=0; i<seq.Length; i++){
          for(int j=0; j<seq.Length; j++){
             if(seq[i]==seq[j]){
               chek++;
             }
          };
 
        if(chek%2>0){
          save = seq[i];
        };
        chek=0;
      }
     // Console.WriteLine(save);
      return save;
      }
   
    public static void Main(string[] args)
     {
       int[] arr = {1,0,1,0,1};
       int result = find_it(arr);
       Console.WriteLine(result);
     }
    }
}