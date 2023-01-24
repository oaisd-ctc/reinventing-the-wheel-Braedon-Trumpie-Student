
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = {5, 1, 11, -6, 45, 100};
        double[] arr = {-500, 3.0, 4.0, 10.0, 11.0, 50.0, 60.0, 80.0, 90.0, 195};
        
        Console.WriteLine(Arrays.ArrayUtils.GetIQR(arr));
        Console.WriteLine(Arrays.ArrayUtils.GetNumberOfOutliers(arr));
    }
}