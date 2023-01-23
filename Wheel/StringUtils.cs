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
        public static void Reverse(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }

    }
}