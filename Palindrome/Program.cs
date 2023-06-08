using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        private bool Palindrome(string s)
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
