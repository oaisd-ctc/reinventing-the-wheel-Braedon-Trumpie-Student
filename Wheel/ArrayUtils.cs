public class ArrayUtils
{
    // Find the average of every number in array a
    public static double Average(int[] a)
    {
        double average = 0;
        foreach(int i in a)
            average += i;
        return average / a.Length;
    }
    public static double Average(double[] a)
    {
        double average = 0;
        foreach(double i in a)
            average += i;
        return average / a.Length;
    }

    // Find the maximum number in array a
    public static int Max(int[] a)
    {
        int max = -2147483648;
        foreach(int i in a)
            if(i > max)
                max = i;
        return max;
    }
    public static double Max(double[] a)
    {
        double max = -2147483648;
        foreach(double i in a)
            if(i > max)
                max = i;
        return max;
    }

    // Find the minimum number in array a
    public static int Min(int[] a)
    {
        int min = 2147483647;
        foreach(int i in a)
            if(i < min)
                min = i;
        return min;
    }
    public static double Min(double[] a)
    {
        double min = 2147483647;
        foreach(double i in a)
            if(i < min)
                min = i;
        return min;
    }

    //Sort array a in ascending order
    public static void SortAscending(int[] a)
    {
        if(a.Length > 2)
            Merge(a, a[0], a[a.Length / 2]);
        else
        {
           sort(a);
        }
    }
    private static void Merge(int[] a, int start, int end)
    {
        if(a.Length > 2)
            Merge(a, a[0], a.Length / 2);
        else
        {
            sort(a);
        }
    }
    private static int[] sort(int[] a)
    {
        if(a.Length > 1 && a[0] > a[1])
        {
            int aTemp = a[0];
            a[0] = a[1];
            a[1] = aTemp;
        }
        return a;
    }
}