namespace Math
{
    public static class MathUtils
    {
        // Return a^b
        public static int Power(int a, int b)
        {
            for(int i = 0; i < b; i++)
            {
                a *= a;
            }
            return a;
        }

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
                            precision++;
                        }
                    }
                }
                if(precision > 0)
                    break;
            }
            return (max + min) / 2;
        }
        public static int GetNumerator(double a)
        {
            //int times = 0;
            double num = a - (int)a;
            while(((int)num) - num != 0)
            {
                num *= 10;
            }
            return (int)num;
        }
    }
}