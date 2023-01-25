namespace String
{
    public static class StringUtils
    {
        public static string ToUpper(string a)
        {
            string output = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'a' && a[i] <= 'z')
                {
                    output += (char)(a[i] - 'a' + 'A');
                }
                else
                    output += a[i];
            }
            return output;
        }
        public static string ToLower(string a)
        {
            string output = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    output += (char)(a[i] - 'A' + 'a');
                }
                else
                    output += a[i];
            }
            return output;
        }
        public static int Length(string s)
        {
            int Length = 0;
            foreach (char c in s)
            {
                Length++;
            }
            return Length;
        }
        public static string Reverse(string a)
        {
            // StringUtils.ToLower(a);
            char[] stringArray = a.ToCharArray();

            string reverse = string.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }
            
            return reverse;
        }
        public static int CountVowels(string s)
        {
            StringUtils.ToLower(s);
            int Vowels = 0;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    Vowels++;
                }
            }
            return Vowels;
        }
        public static int CountConsonants(string s)
        {
            StringUtils.ToLower(s);
            int Consonants = 0;
            int Vowels = 0;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    Vowels++;
                }
                else
                {
                    Consonants++;
                }
            }
            return Consonants;
        }
        public static bool HasLetter(string s, char a)
        {
            StringUtils.ToLower(s);
            char.ToLower(a);
            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                if (s[i] == a)
                {
                    return true;
                }

            }
            return false;

        }
        public static string CapsfirstLetter(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return $"{char.ToUpper(s[0])}{s[1..]}";
        }

        public static string CapslastLetter(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            var stringArray = s.ToCharArray();
            if (char.IsLower(stringArray[s.Length - 1]))
            {
                stringArray[s.Length - 1] = char.ToUpper(stringArray[s.Length - 1]);
            }
            return new string(stringArray);
        }
        public static bool IsPalindrome(string s)
        {
            string bleh = StringUtils.ToLower(s);
            return bleh.SequenceEqual(bleh.Reverse());
        }

        public static string StringRemoveSpaces(string s)
        {
            string thing = s.Replace(" ", string.Empty);
            return thing;

        }


    }
}