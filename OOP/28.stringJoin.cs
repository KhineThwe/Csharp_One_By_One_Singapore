using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
         string[] fruits = {"apple","banana","orange"};
         string joinedString = string.Join(",",fruits);
         Console.WriteLine(joinedString);
         //"apple,banana,orange"
       }
    }
}