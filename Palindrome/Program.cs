using System;

namespace Palindrome
{
    class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg}->{Palindrome(arg)}");
            }
        }


        private static bool Palindrome(string s)
        {
            bool IsString(string s)
            {
                char[] array=s.ToCharArray();
                Array.Reverse(array);
                    
                    
                if (s==new string(array))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


            if (s==null)
            {
                throw new ArgumentNullException("String cant be null");
            }
            else if(s.Length<2)
            {
                return true;
            }
            else
            {
                return IsString(s);
            }
            
        }
    }
}
