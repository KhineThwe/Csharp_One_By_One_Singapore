using System;

namespace accessStrings
{
    class Access{
        public static void Main(string[] args){
            string sentence = "Hi,How are you?";
            string[] words = sentence.Split(' ');
            for(int i =0 ;i< words.Length;i++){
                Console.WriteLine(words[i]);
            }      
       }
    }
}