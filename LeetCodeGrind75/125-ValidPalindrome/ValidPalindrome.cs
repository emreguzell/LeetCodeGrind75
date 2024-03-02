namespace LeetCodeGrind75._125_ValidPalindrome
{
    public class Solution125
    {
        public bool IsPalindrome(string s)
        {
            var filtered = "";
            foreach (var c in s)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    filtered += Char.ToLower(c);
                }
            }
            char[] charArray = filtered.ToCharArray();
            Array.Reverse(charArray);
            var reversedString = new string(charArray);
            return (filtered.Equals(reversedString)) ? true : false;
        }
    }
}
