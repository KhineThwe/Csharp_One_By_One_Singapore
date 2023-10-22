using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
            string originalString = "Hello World";
            string subString = originalString.Substring(0,3);
            Console.WriteLine(subString);
       }
    }
}