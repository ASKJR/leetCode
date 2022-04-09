using System;
using System.Linq;

namespace C_Sharp.PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string reversed = new string(x.ToString().Reverse().ToArray());
            if (x < 0) return false;
            return x.ToString() == reversed;   
        }
    }
}
