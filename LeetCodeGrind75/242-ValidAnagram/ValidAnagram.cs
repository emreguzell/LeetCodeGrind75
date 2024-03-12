using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._242_ValidAnagram
{
    public class Solution242
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length < 1 || t.Length < 1 || s.Length != t.Length || s == null || t == null)
            {
                return false;
            }
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            Array.Sort(s1);
            Array.Sort(t1);
            string s2 = new string(s1);
            string t2 = new string(t1);
            return s2 == t2;
        }
    }
}
