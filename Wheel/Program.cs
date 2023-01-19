
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = {5, 7, 11, -6, 45, 100};
        ArrayUtils.SortAscending(array);
        foreach(int i in array)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}