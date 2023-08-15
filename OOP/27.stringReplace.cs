using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
         string originalString = "I like cats";
         string modifiedString = originalString.Replace("cats","dogs");
         Console.WriteLine(modifiedString);

         string sentence = "The quick brown fox jumps over the lazy dog";
         bool containsFox = sentence.Contains("fox");
         if(containsFox == true){
            Console.WriteLine("Contains");
         }
       }
    }
}