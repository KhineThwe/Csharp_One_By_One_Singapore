using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
         //EndsWith()
         string fileName = "document.txt";
         bool endsWithTxt = fileName.EndsWith(".txt");
         if(endsWithTxt==true){
            Console.WriteLine("True");
         }
       }
    }
}