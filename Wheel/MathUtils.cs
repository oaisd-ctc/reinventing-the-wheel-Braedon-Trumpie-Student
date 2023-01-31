namespace Math
{
    public static class MathUtils
    {
        // Return a^b
        ///<summary>
        ///Finds the result of a raised to the b.
        ///</summary>
        ///<param name="a">The base number.</param>
        ///<param name="b">The exponent.</param>
        ///<returns>
        ///a^b
        ///</returns>
        public static int Power(int a, int b)
        {
            int firsta = a;
            for(int i = 1; i < b; i++)
            {
                a *= firsta;
            }
            return a;
        }
        ///<summary>
        ///Finds the result of a raised to the b.
        ///</summary>
        ///<param name="a">The base number.</param>
        ///<param name="b">The exponent.</param>
        ///<returns>
        ///a^b
        ///</returns>
        public static double Power(double a, int b)
        {
            double firsta = a;
            for(int i = 1; i < b; i++)
            {
                a *= firsta;
            }
            return a;
        }
        ///<summary>
        ///Finds the result of a raised to the b.
        ///</summary>
        ///<param name="a">The base number.</param>
        ///<param name="b">The exponent.</param>
        ///<returns>
        ///a^b
        ///</returns>

        public static double Power(double a, double b)
        {
            double firsta = a;
            for(int i = 1; i < SimplifiedNumerator(b); i++)
            {
                a *= firsta;
            }
            return Root(a, SimplifiedDenominator(b));
        }
        ///<summary>
        ///Finds the square root of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///a^(1/2)
        ///</returns>
        //return the square root of a
        public static double SquareRoot(int a)
        {
            double max = a;
            double min = 0;
            double prevMin = 0;
            int precision = 0;
            while(max * max > a)
            {
                max /= 2;
                if(max * max < a)
                {
                    min = max;
                    max *= 2;
                    while(min * min < a)
                    {
                        prevMin = min;
                        min = (max + min) / 2;
                        if(min * min > a)
                        {
                            max = min;
                            min = prevMin;
                        }
                        precision++;
                        if(precision > 20)
                            break;
                    }
                }
                if(precision > 5)
                    break;
            }
            return (max + min) / 2;
        }
        ///<summary>
        ///Finds the square root of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///a^(1/2)
        ///</returns>
        public static double SquareRoot(double a)
        {
            double max = a;
            double min = 0;
            double prevMin = 0;
            int precision = 0;
            while(max * max > a)
            {
                max /= 2;
                if(max * max < a)
                {
                    min = max;
                    max *= 2;
                    while(min * min < a)
                    {
                        prevMin = min;
                        min = (max + min) / 2;
                        if(min * min > a)
                        {
                            max = min;
                            min = prevMin;
                        }
                        precision++;
                        if(precision > 20)
                            break;
                    }
                }
                if(precision > 5)
                    break;
            }
            return (max + min) / 2;
        }
        ///<summary>
        ///Finds the cube root of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///a^(1/3)
        ///</returns>
        //returns the cube root of a
        public static double CubeRoot(int a)
        {
            double max = a;
            double min = 0;
            double prevMin = 0;
            int precision = 0;
            while(max * max * max >= a)
            {
                max /= 2;
                if(max * max * max < a)
                {
                    min = max;
                    max *= 2;
                    while(min * min * min < a)
                    {
                        prevMin = min;
                        min = (max + min) / 2;
                        if(min * min * min > a)
                        {
                            max = min;
                            min = prevMin;
                        }
                        precision++;
                        if(precision > 20)
                            break;
                    }
                }
                if(precision > 5)
                    break;
            }
            return (max + min) / 2;
        }
        ///<summary>
        ///Finds the cube root of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///a^(1/3)
        ///</returns>
        public static double CubeRoot(double a)
        {
            double max = a;
            double min = 0;
            double prevMin = 0;
            int precision = 0;
            while(max * max * max >= a)
            {
                max /= 2;
                if(max * max * max < a)
                {
                    min = max;
                    max *= 2;
                    while(min * min * min < a)
                    {
                        prevMin = min;
                        min = (max + min) / 2;
                        if(min * min * min > a)
                        {
                            max = min;
                            min = prevMin;
                        }
                        precision++;
                        if(precision > 20)
                            break;
                    }
                }
                if(precision > 5)
                    break;
            }
            return (max + min) / 2;
        }
        ///<summary>
        ///Finds the b root of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<param name="b">The root.</param>
        ///<returns>
        ///a^(1/b)
        ///</returns>
        //returns a^(1/b)
        public static double Root(double a, int b)
        {
            double max = a;
            double min = 0;
            double prevMin = 0;
            int precision = 0;
            while(Power(max, b) >= a)
            {
                max /= 2;
                if(Power(max, b) < a)
                {
                    min = max;
                    max *= 2;
                    while(Power(min, b) < a)
                    {
                        prevMin = min;
                        min = (max + min) / 2;
                        if(Power(min, b) > a)
                        {
                            max = min;
                            min = prevMin;
                        }
                        precision++;
                        if(precision > 20)
                            break;
                    }
                }
                if(precision > 5)
                    break;
            }
            return (max + min) / 2.0;
        }
        ///<summary>
        ///Finds the unsimplified numerator of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///The unsimplified numerator of a.
        ///</returns>
        public static int GetNumerator(double a)
        {
            //Console.WriteLine("a = " + a + ", (int)a = " + (int)a);
            decimal num = (decimal)a - (int)a;
            //Console.WriteLine("num = " + num);
            while((num * 10) % 10 != 0)
            {
                num *= 10;
                //Console.WriteLine("num = " + num);
            }
            //Console.WriteLine("num = " + num);
            return (int)num;
        }
        ///<summary>
        ///Finds the unsimplified denominator of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///The unsimplified denominator of a.
        ///</returns>
        public static int GetDenominator(double a)
        {
            int denominator = 1;
            decimal num = (decimal)a - (int)a;
            while((num * 10) % 10 != 0)
            {
                num *= 10;
                denominator *= 10;
            }
            return denominator;
        }
        ///<summary>
        ///Finds the simplified numerator of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///The simplified numerator of a.
        ///</returns>
        public static int SimplifiedNumerator(double a)
        {
            int num = GetNumerator(a);
            int den = GetDenominator(a);
            for(int i = 2; i < num / 2 + 1; i++)
            {
                if(num % i == 0 && den % i == 0)
                {
                    num /= i;
                    den /= i;
                }
            }
            if(den % num == 0)
                return 1;
            return num;
        }
        ///<summary>
        ///Finds the simplified denominator of a.
        ///</summary>
        ///<param name="a">The number.</param>
        ///<returns>
        ///The simplified denominator of a.
        ///</returns>
        public static int SimplifiedDenominator(double a)
        {
            int num = GetNumerator(a);
            int den = GetDenominator(a);
            for(int i = 2; i < num / 2 + 1; i++)
            {
                if(num % i == 0 && den % i == 0)
                {
                    num /= i;
                    den /= i;
                }
            }
            if(den % num == 0)
                return den / num;
            return den;
        }
    }
}