using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roberts_StringMeAlong
{
    internal class StringManager
    {
      
        public StringManager()
        { 
           
        }
        public string goBackwards(string stringToReverse)
        {
            string reverse = string.Empty;
            Char[] array = stringToReverse.ToCharArray();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse = reverse + array[i];
            }
            return reverse;
        }
        public bool symmetric(string isItTheSame)
        {
            bool symmetrical = true;
            string backwards = goBackwards(isItTheSame);
            char[] goForwards = isItTheSame.ToCharArray();
            char[] back = backwards.ToCharArray();
            
            foreach(char c in goForwards)
            {
                foreach (char c2 in backwards)
                    if(c != c2)
                    {
                        symmetrical = false;
                    }
                else symmetrical = true;
                    
            }
            return symmetrical;
    
        }
        public string[] asciiValue(string valueMap)
        {
            double value = 0;
            byte[] array = Encoding.ASCII.GetBytes(valueMap);
            string num = string.Empty;
            string[]number = new string[array.Length];


            foreach (byte b in array)
            {
                value = value + b;  
            }
            foreach (char c in value.ToString())
            {
                for(int i = 0; i < array.Length; i++)
                {
                    if (c == 0)
                    {
                        number[i] = "zero ";

                    }
                    if (c == 1)
                    {
                        number[i] = "one ";
                    }
                    if (c == 2)
                    {
                        number[i] = "two ";
                    }
                    if (c == 3)
                    {
                        number[i] = "three ";
                    }
                    if (c == 4)
                    {
                        number[i] = "four ";
                    }
                    if (c == 5)
                    {
                        number[i] = "five ";
                    }
                    if (c == 6)
                    {
                        number[i] = "six ";
                    }
                    if (c == 7)
                    {
                        number[i] = "seven ";
                    }
                    if (c == 8)
                    {
                        number[i] = "eight ";
                    }
                    if (c == 9)
                    {
                        number[i] = "nine ";
                    }
                }
            }
          
           
            Console.WriteLine(value);
           return number;
          
        }
        //public string casePreservation(string preserveCapitals)//not working
        //{
        //    char[] array = preserveCapitals.ToCharArray();
        //    bool upper = true;
        //    string reverse = string.Empty;
        //    char[] array2 = reverse.ToCharArray();
        //    string finalReverse = string.Empty;

        //    foreach (char c in array)
        //    {
        //        for (int i = array.Length - 1; i >= 0; i--)
        //        {
        //            if (char.IsUpper(c))
        //            {
        //                reverse = reverse + char.ToUpper(c);
        //            }
        //            else
        //            {
        //                reverse = reverse + char.ToLower(c);
        //            }

        //        }
        //        //Console.WriteLine(c);
        //    }
          
        //    return reverse;

        
            
    }
}
