using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            if (word == null || word.Length == 0)
            {
                return false;
            }
            string lowered = word.ToLower();
            string reversed = "";

            for (int i = lowered.Length - 1; i >= 0; i--)
            {
                reversed += lowered[i];
            }
            if (lowered == reversed)
            {
                return true;
            }
            return false;


        }
    }
}
