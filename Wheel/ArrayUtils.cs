namespace Arrays
{
    public class ArrayUtils
    {
        // Find the average of every number in array a
        public static double Average(int[] a)
        {
            double average = 0;
            foreach (int i in a)
                average += i;
            return average / a.Length;
        }
        public static double Average(double[] a)
        {
            double average = 0;
            foreach (double i in a)
                average += i;
            return average / a.Length;
        }

        // Find the maximum number in array a
        public static int Max(int[] a)
        {
            int max = -2147483648;
            foreach (int i in a)
                if (i > max)
                    max = i;
            return max;
        }
        public static double Max(double[] a)
        {
            double max = -2147483648;
            foreach (double i in a)
                if (i > max)
                    max = i;
            return max;
        }

        // Find the minimum number in array a
        public static int Min(int[] a)
        {
            int min = 2147483647;
            foreach (int i in a)
                if (i < min)
                    min = i;
            return min;
        }
        public static double Min(double[] a)
        {
            double min = 2147483647;
            foreach (double i in a)
                if (i < min)
                    min = i;
            return min;
        }
        public static int Min(int[] a, int start)
        {
            int min = 2147483647;
            for(int i = start; i < a.Length; i++)
            {
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        //Sort array a in ascending order
        public static void SortAscending(int[] a)
        {
            int min;
            int minIndex = 0;
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                min = int.MaxValue;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                    if (j == a.Length - 1)
                    {
                        temp = a[i];
                        a[i] = min;
                        a[minIndex] = temp;
                    }
                }
            }
        }
        
        public static void SortAscending(double[] a)
        {
            double min;
            int minIndex = 0;
            double temp;
            for (int i = 0; i < a.Length; i++)
            {
                min = double.MaxValue;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndex = j;
                    }
                    if (j == a.Length - 1)
                    {
                        temp = a[i];
                        a[i] = min;
                        a[minIndex] = temp;
                    }
                }
            }
        }

        //Sort array b in descending order
        public static void SortDescending(int[] a)
        {
            int max;
            int maxIndex = 0;
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                max = int.MinValue;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] > max)
                    {
                        max = a[j];
                        maxIndex = j;
                    }
                    if (j == a.Length - 1)
                    {
                        temp = a[i];
                        a[i] = max;
                        a[maxIndex] = temp;
                    }
                }
            }
        }
        public static void SortDescending(double[] a)
        {
            double max;
            int maxIndex = 0;
            double temp;
            for (int i = 0; i < a.Length; i++)
            {
                max = double.MinValue;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[j] > max)
                    {
                        max = a[j];
                        maxIndex = j;
                    }
                    if (j == a.Length - 1)
                    {
                        temp = a[i];
                        a[i] = max;
                        a[maxIndex] = temp;
                    }
                }
            }
        }

        //add up all numbers in the array
        public static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
                sum += x;
            return sum;
        }
        public static double Sum(double[] a)
        {
            double sum = 0;
            foreach (double x in a)
                sum += x;
            return sum;
        }
        public static int Product(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
                sum *= x;
            return sum;
        }
        public static double Product(double[] a)
        {
            double sum = 0;
            foreach (double x in a)
                sum *= x;
            return sum;
        }

        //NEW METHODS

        //Returns true if array a is symmetrical, and false otherwise
        public static bool IsSymmetrical(int[] a)
        {
            for(int i = 0; i < (a.Length / 2) + 1; i++)
                if(a[i] != a[a.Length - i -1])
                    return false;
            return true;
        }
        public static bool IsSymmetrical(double[] a)
        {
            for(int i = 0; i < (a.Length / 2) + 1; i++)
                if(a[i] != a[a.Length - i -1])
                    return false;
            return true;
        }

        //Find Q3 of array a
        public static double GetQ3(double[] a)
        {
            double[] b = a;
            SortAscending(b);
            //Find Q3 if array length is odd
            if(b.Length % 2 == 1)
            {
                int medIndex = (b.Length / 2);
                if((medIndex + 1) % 2 == 1)
                    return b[medIndex + ((medIndex + 1) / 2)];
                else
                    return (b[medIndex + (medIndex / 2)] + b[medIndex + (medIndex / 2) + 1]) / 2;
            }
            //FindQ3 if array length is even
            else
            {
                if(a.Length % 4 == 0)
                    return (b[b.Length - (b.Length / 4)] + b[b.Length - (b.Length / 4) - 1]) / 2;
                else
                    return b[(b.Length - (b.Length / 4)) - 1];
            }
        }
        //Find Q3 of array a
        public static double GetQ1(double[] a)
        {
            double[] b = a;
            SortAscending(b);
            //Find Q1 if array length is odd
            if(b.Length % 2 == 1)
            {
                int medIndex = (b.Length / 2);
                if((medIndex + 1) % 2 == 1)
                    return b[medIndex / 2];
                else
                    return (b[(medIndex + 1) / 2] + b[((medIndex + 1) / 2) - 1]) / 2;
            }
            //FindQ3 if array length is even
            else
            {
                if(a.Length % 4 == 0)
                    return (b[(b.Length / 2) / 2] + b[((b.Length / 2) / 2) - 1]) / 2;
                else
                    return b[b.Length / 4];
            }
        }

        //Find the IQR of array a
        public static double GetIQR(double[] a)
        {
            return GetQ3(a) - GetQ1(a);
        }
        public static int GetNumberOfOutliers(double[] a)
        {
            int nums = 0;
            foreach(int x in a)
                if(x > (GetQ3(a) + (1.5 * GetIQR(a))) || x < (GetQ1(a) - (1.5 * GetIQR(a))))
                    nums++;
            return nums;

        }
    }


}