namespace Arrays
{
    public class ArrayUtils
    {
        ///<summary>
        ///Finds the average of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the average of your array
        ///</returns>
        // Find the average of every number in array a
        public static double Average(int[] a)
        {
            double average = 0;
            foreach (int i in a)
                average += i;
            return average / a.Length;
        }
        ///<summary>
        ///Finds the average of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the average of your array
        ///</returns>
        // Find the average of every number in array a
        public static double Average(double[] a)
        {
            double average = 0;
            foreach (double i in a)
                average += i;
            return average / a.Length;
        }
        ///<summary>
        ///Finds the maximum of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the maximum number of your array
        ///</returns>
        // Find the maximum number in array a
        public static int Max(int[] a)
        {
            int max = -2147483648;
            foreach (int i in a)
                if (i > max)
                    max = i;
            return max;
        }
        ///<summary>
        ///Finds the maximum of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the maximum number of your array
        ///</returns>
        public static double Max(double[] a)
        {
            double max = -2147483648;
            foreach (double i in a)
                if (i > max)
                    max = i;
            return max;
        }
        ///<summary>
        ///Finds the minimum of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the minimum number of your array
        ///</returns>
        // Find the minimum number in array a
        public static int Min(int[] a)
        {
            int min = 2147483647;
            foreach (int i in a)
                if (i < min)
                    min = i;
            return min;
        }
        ///<summary>
        ///Finds the minimum of array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///the minimum number of your array
        ///</returns>
        public static double Min(double[] a)
        {
            double min = 2147483647;
            foreach (double i in a)
                if (i < min)
                    min = i;
            return min;
        }

        ///<summary>
        ///Sorts array a in ascending order
        ///</summary>
        ///<param name="a">The array.</param>
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
        ///<summary>
        ///Sorts array a in ascending order
        ///</summary>
        ///<param name="a">The array.</param>
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
        ///<summary>
        ///Sorts array a in descending order
        ///</summary>
        ///<param name="a">The array.</param>
        //Sort array a in descending order
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
        ///<summary>
        ///Sorts array a in descending order
        ///</summary>
        ///<param name="a">The array.</param>
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

        ///<summary>
        ///Finds the sum of all numbers in array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The sum of all numbers in array a
        ///</returns>
        //add up all numbers in the array
        public static int Sum(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
                sum += x;
            return sum;
        }
        ///<summary>
        ///Finds the sum of all numbers in array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The sum of all numbers in array a
        ///</returns>
        public static double Sum(double[] a)
        {
            double sum = 0;
            foreach (double x in a)
                sum += x;
            return sum;
        }
        ///<summary>
        ///Finds the product of all numbers in array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The product of all numbers in array a
        ///</returns>
        public static int Product(int[] a)
        {
            int sum = 1;
            foreach (int x in a)
                sum *= x;
            return sum;
        }
        ///<summary>
        ///Finds the product of all numbers in array a
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The product of all numbers in array a
        ///</returns>
        public static double Product(double[] a)
        {
            double sum = 1;
            foreach (double x in a)
                sum *= x;
            return sum;
        }

        //NEW METHODS

        ///<summary>
        ///Checks if array a is symmetrical.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///True if array a is symmetrical, and false otherwise
        ///</returns>
        //Returns true if array a is symmetrical, and false otherwise
        public static bool IsSymmetrical(int[] a)
        {
            for (int i = 0; i < (a.Length / 2) + 1; i++)
                if (a[i] != a[a.Length - i - 1])
                    return false;
            return true;
        }
        ///<summary>
        ///Checks if array a is symmetrical.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///True if array a is symmetrical, and false otherwise
        ///</returns>
        public static bool IsSymmetrical(double[] a)
        {
            for (int i = 0; i < (a.Length / 2) + 1; i++)
                if (a[i] != a[a.Length - i - 1])
                    return false;
            return true;
        }
        ///<summary>
        ///Finds Q3 of array a.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///Q3 of array a.
        ///</returns>
        //Find Q3 of array a
        public static double GetQ3(double[] a)
        {
            double[] b = a;
            SortAscending(b);
            //Find Q3 if array length is odd
            if (b.Length % 2 == 1)
            {
                int medIndex = (b.Length / 2);
                if ((medIndex + 1) % 2 == 1)
                    return b[medIndex + ((medIndex + 1) / 2)];
                else
                    return (b[medIndex + (medIndex / 2)] + b[medIndex + (medIndex / 2) + 1]) / 2;
            }
            //FindQ3 if array length is even
            else
            {
                if (a.Length % 4 == 0)
                    return (b[b.Length - (b.Length / 4)] + b[b.Length - (b.Length / 4) - 1]) / 2;
                else
                    return b[(b.Length - (b.Length / 4)) - 1];
            }
        }
        ///<summary>
        ///Finds Q1 of array a.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///Q1 of array a.
        ///</returns>
        //Find Q3 of array a
        public static double GetQ1(double[] a)
        {
            double[] b = a;
            SortAscending(b);
            //Find Q1 if array length is odd
            if (b.Length % 2 == 1)
            {
                int medIndex = (b.Length / 2);
                if ((medIndex + 1) % 2 == 1)
                    return b[medIndex / 2];
                else
                    return (b[(medIndex + 1) / 2] + b[((medIndex + 1) / 2) - 1]) / 2;
            }
            //Find Q1 if array length is even
            else
            {
                if (a.Length % 4 == 0)
                    return (b[(b.Length / 2) / 2] + b[((b.Length / 2) / 2) - 1]) / 2;
                else
                    return b[b.Length / 4];
            }
        }
        ///<summary>
        ///Finds the interquartile range of array a.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The IQR of array a.
        ///</returns>
        //Find the IQR of array a
        public static double GetIQR(double[] a)
        {
            return GetQ3(a) - GetQ1(a);
        }
        ///<summary>
        ///Finds the number of outliers in array a.
        ///</summary>
        ///<param name="a">The array.</param>
        ///<returns>
        ///The number of outliers in array a.
        ///</returns>
        public static int GetNumberOfOutliers(double[] a)
        {
            int nums = 0;
            foreach (double x in a)
                if (x > (GetQ3(a) + (1.5 * GetIQR(a))) || x < (GetQ1(a) - (1.5 * GetIQR(a))))
                    nums++;
            return nums;

        }
    }


}