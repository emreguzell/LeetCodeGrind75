using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeGrind75._020_Valid_Parentheses
{
    public class Solution020
    {
        public bool IsValid(string s)
        {
            Stack<char> openningParantheses = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    openningParantheses.Push(c);
                }
                else
                {
                    if (openningParantheses.Count == 0) return false;
                    var openning = openningParantheses.Peek();
                    if (openning == '(' && c == ')'
                       || openning == '{' && c == '}'
                       || openning == '[' && c == ']')
                    {
                        openningParantheses.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (openningParantheses.Count > 0) return false;
            return true;
        }
    }
}
