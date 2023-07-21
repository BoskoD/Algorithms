namespace ValidPalindrome
{
    internal class Program // Two Pointers, String
    {
        static void Main(string[] args)
        {
            string s = "A man, a plan, a canal: Panama";
            bool isValidPalindrome = DetectValidPalindrome(s);
            Console.WriteLine($"{s} is a valid palindrome? {isValidPalindrome}");
        }

        public static bool DetectValidPalindrome(string s)
        { 
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left])) { left++; }
                else if (!char.IsLetterOrDigit(s[right])) { right--; }
                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right])) 
                    { 
                        return false; 
                    }
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}