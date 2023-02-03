namespace String
{
    public static class StringUtils
    {
        ///<summary>
        ///Capitalizes letters in strings
        ///</summary>
        ///<param name="a">The users string.</param>
        ///<returns>
        ///A fully capitalized string
        ///</returns>
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
        ///<summary>
        ///Turns letters in strings into a lowercase form
        ///</summary>
        ///<param name="a">The users string.</param>
        ///<returns>
        ///A fully lowercase string
        ///</returns>
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
        ///<summary>
        ///Takes a string and counts how many characters are in it
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///An int of number of characters
        ///</returns>
        public static int Length(string s)
        {
            int Length = 0;
            foreach (char c in s)
            {
                Length++;
            }
            return Length;
        }
        ///<summary>
        ///Reverses a string
        ///</summary>
        ///<param name="a">The users string.</param>
        ///<returns>
        ///Returns users string but in reverse
        ///</returns>
        public static string Reverse(string a)
        {

            
            string reverse = string.Empty;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                reverse += a[i];
            }

            return reverse;
        }
        ///<summary>
        ///Count the amount of vowels in a string
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns an int of number of vowels
        ///</returns>
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
        ///<summary>
        ///Count the amount of cnsonants in a string
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns an int of number of consonants
        ///</returns>
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
        ///<summary>
        ///Searches a string to see if it has a specific character
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<param name="a">Character your looking for.</param>
        ///<returns>
        ///Returns a bool saying if it has said letter
        ///</returns>
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
        ///<summary>
        ///Capitalizes the first letter of a string
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns a string with a capital first letter
        ///</returns>
        public static string CapsfirstLetter(string s)
        {

            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return $"{char.ToUpper(s[0])}{s[1..]}";
        }
         ///<summary>
        ///Capitalizes the last letter of a string
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns a string with a capital last letter
        ///</returns>

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
         ///<summary>
        ///Checks to see if the string is a palindrome
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns a bool on whether the string is a palindrome
        ///</returns>
        public static bool IsPalindrome(string s)
        {
            string bleh = StringUtils.ToLower(s);
            return bleh.SequenceEqual(StringUtils.Reverse(bleh));
        }
         ///<summary>
        ///Takes out spaces of a given string
        ///</summary>
        ///<param name="s">The users string.</param>
        ///<returns>
        ///Returns a string without spaces in it
        ///</returns>

        public static string StringRemoveSpaces(string s)
        {
            string thing = s.Replace(" ", string.Empty);
            return thing;

        }


    }
}