using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
          string str1 = "apple";
          string str2 = "apple";

          int result = string.Compare(str1,str2);
          Console.WriteLine(result);//Negative value return if not equal//if equal -> 0
          if(result == -1){
            Console.WriteLine("They are not equal");
          }else{
            Console.WriteLine("They are equal");
          }
       }
    }
}