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
        //Addition

        ///<summary>
        ///Adds two intigers together
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the sum of the two intigers
        ///</returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }
        ///<summary>
        ///Adds two doubles together
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the sum of the two doubles
        ///</returns>
        public static double Add(double x, double y)
        {
            return x + y;
        }
        ///<summary>
        ///Adds two floats together
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the sum of the two floats
        ///</returns>
        public static float Add(float x, float y)
        {
            return x + y;
        }
        //Subtraction

        ///<summary>
        ///Subracts two intiger 
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the difference of the two intigers
        ///</returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        ///<summary>
        ///Subracts two doubles 
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the difference of the two doubles
        ///</returns>
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        ///<summary>
        ///Subracts two floats 
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the difference of the two floats
        ///</returns>
        public static float Subtract(float x, float y)
        {
            return x - y;
        }
        //Multiplication

        ///<summary>
        ///Multiplys two intigers together
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the product of the two intigers
        ///</returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        ///<summary>
        ///Multiplys two doubles together
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the product of the two doubles
        ///</returns>
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        ///<summary>
        ///Multiplys two floats together
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the product of the two floats
        ///</returns>
        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        //Division

        ///<summary>
        ///Divides two intigers 
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the quotient of the two intigers
        ///</returns>
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        ///<summary>
        ///Divides two doubles 
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the quotient of the two doubles
        ///</returns>
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        ///<summary>
        ///Divides two floats 
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the quotient of the two floats
        ///</returns>
        public static float Divide(float x, float y)
        {
            return x / y;
        }
        //Min

        ///<summary>
        ///Tells what intiger is the minimum of the two intigers 
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the minimum of the two intigers
        ///</returns>
        public static int Min(int x, int y)
        {
            int Min = x;
            if (Min > y)
                Min = y;

            return Min;

        }
        ///<summary>
        ///Tells what double is the minimum of the two doubles 
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the minimum of the two doubles
        ///</returns>
        public static double Min(double x, double y)
        {
            double Min = x;
            if (Min > y)
                Min = y;
            return Min;

        }
        ///<summary>
        ///Tells what float is the minimum of the two floats 
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the minimum of the two floats
        ///</returns>
        public static float Min(float x, float y)
        {
            float Min = x;
            if (Min > y)
                Min = y;
            return Min;

        }
        //Max

        ///<summary>
        ///Tells what intiger is the maximum of the two intigers 
        ///</summary>
        ///<param name="x">The users first int.</param>
        ///<param name="y">The users second int.</param>
        ///<returns>
        ///Returns the maximum of the two intigers
        ///</returns>
        public static int Max(int x, int y)
        {
            int Max = x;
            if (Max < y)
                Max = y;
            return Max;

        }
        ///<summary>
        ///Tells what double is the maximum of the two doubles 
        ///</summary>
        ///<param name="x">The users first double.</param>
        ///<param name="y">The users second double.</param>
        ///<returns>
        ///Returns the maximum of the two doubles
        ///</returns>
        public static double Max(double x, double y)
        {
            double Max = x;
            if (Max < y)
                Max = y;
            return Max;

        }
        ///<summary>
        ///Tells what float is the maximum of the two floats 
        ///</summary>
        ///<param name="x">The users first float.</param>
        ///<param name="y">The users second float.</param>
        ///<returns>
        ///Returns the maximum of the two floats
        ///</returns>
        public static float Max(float x, float y)
        {
            float Max = x;
            if (Max < y)
                Max = y;
            return Max;
        }
        //Absolute Value

        ///<summary>
        ///Gives the absolute value of any given intiger
        ///</summary>
        ///<param name="x">The users int.</param>
        ///<returns>
        ///Returns the absolute value of the intiger
        ///</returns>
        public static int AbsoluteValue(int x)
        {

            if (x < 0)
            {
                x = -1 * x;
            }
            else if (x > 0)
            {
                x = 1 * x;
            }
            return x;
        }
        ///<summary>
        ///Gives the absolute value of any given double
        ///</summary>
        ///<param name="x">The users double.</param>
        ///<returns>
        ///Returns the absolute value of the double
        ///</returns>
        public static double AbsoluteValue(double x)
        {

            if (x < 0)
            {
                x = -1 * x;
            }
            else if (x > 0)
            {
                x = 1 * x;
            }
            return x;
        }
        ///<summary>
        ///Gives the absolute value of any given float
        ///</summary>
        ///<param name="x">The users float.</param>
        ///<returns>
        ///Returns the absolute value of the float
        ///</returns>
        public static float AbsoluteValue(float x)
        {

            if (x < 0)
            {
                x = -1 * x;
            }
            else if (x > 0)
            {
                x = 1 * x;
            }
            return x;
        }
        //Sales tax

        ///<summary>
        ///Tells the total of the item with sales tax included
        ///</summary>
        ///<param name="x">The item price</param>
        ///<param name="statetax">The tax rate in your state</param>
        ///<returns>
        ///Returns the price of the item with salestax included(Double)
        ///</returns>
        public static double salesTax(double x, double statetax)
        {
            double tax = statetax * x;
            return x + tax;
        }
        ///<summary>
        ///Tells the total of the item with sales tax included
        ///</summary>
        ///<param name="x">The item price</param>
        ///<param name="statetax">The tax rate in your state</param>
        ///<returns>
        ///Returns the price of the item with salestax included(float)
        ///</returns>
        public static float salesTax(float x, float statetax)
        {
            float tax = statetax * x;
            return x + tax;
        }

    }
}