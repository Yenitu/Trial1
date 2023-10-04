/*
Class: CSE 1322L
Section: W1
Term: Fall 2022
Instructor: Enda Sullivan
Name: Tiyeni Mbutu
Lab#: Assignment 5
*/
using System;
using System.Collections.Generic;
namespace Assignement5
{
    class Assignment5
    {
        public static List<string> ListOfStrings = new List<string>();
        public static int maxSize = 5;

        public static void makeWords (int length, string word)
        {
            if(length == 6)
            {
                return;
            }
            else
            {
                for (char a = 'A'; a< 'Z'; a++)
                {
                    ListOfStrings.Add(word+a);
                }
                for (char a = 'A'; a < 'Z'; a++)
                {
                    if (word.Length < length)
                    {
                        makeWords(length+1, word + a);
                    }
                }
            }
        }
 
        static void Main(string[] args)
        {
            string pw1 = "1c75d402fb481523acd44e9d8247bc80";
            string pw2 = "5b1d59b5451c06afb65ab1bc2713cfb4";
            string hash;
            PasswordHash pwHash = new PasswordHash();
            makeWords(1, "");
            foreach(string word in ListOfStrings)
            {
                hash = pwHash.hashPW(word);
                if (pw1 == hash)
                {
                    Console.WriteLine("Found Password 1, word used was: " + word);
                }
                if (pw2 == hash)
                {
                    Console.WriteLine("Found Password 2, word used was: " + word);
                }
            }
        }
    }
}
