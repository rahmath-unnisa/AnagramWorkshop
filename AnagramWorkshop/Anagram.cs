using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramWorkshop
{
    public class Anagram
    {
        public void AnagramOrNot()
        {
            Console.WriteLine("Enter The First String");
            String String1 = Console.ReadLine();
            Console.WriteLine("Enter The Secong String");
            String String2 = Console.ReadLine();
            char[] first = String1.ToLower().ToCharArray();
            char[] second = String2.ToLower().ToCharArray();
            Array.Sort(first);
            Array.Sort(second);
            String Word1 = new String(first);
            String Word2 = new String(second);
            if (Word1.Equals(Word2))
            {
                Console.WriteLine("They are anagram");
            }
            else
            {
                Console.WriteLine("They are not anagram");
            }
            Console.ReadLine();
        }
    }
}
