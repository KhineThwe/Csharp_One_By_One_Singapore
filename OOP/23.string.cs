using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
            string name = "Jame";
            int age = 30;
            string formattedString  = string.Format("My name is {0} and I am {1} years old",name,age);
            Console.WriteLine(formattedString);
       }
    }
}