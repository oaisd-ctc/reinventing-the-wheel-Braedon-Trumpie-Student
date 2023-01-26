using Xunit;
using String;
public static class Tests
{
    //string
    [Fact]
    public static void StringToLower()
    {
        string desiredOutcome = "connall";
        Assert.Equal(desiredOutcome, StringUtils.ToLower("CoNnAlL"));
    }
    [Fact]
    public static void StringToUpper()
    {
        string desiredOutcome = "CONNALL";
        Assert.Equal(desiredOutcome, StringUtils.ToUpper("connall"));
    }
    [Fact]
    public static void StringLength(){
        int desiredOutcome = 7;
        Assert.Equal(desiredOutcome, StringUtils.Length("Connall"));
    }
    [Fact]
    public static void StringReverse()
    {
        string desiredOutcome = "LLANNOC";
        Assert.Equal(desiredOutcome, StringUtils.Reverse("CONNALL"));
    }
    [Fact]
    public static void StringCountVowels()
    {
        int desiredOutcome = 2;
        Assert.Equal(desiredOutcome, StringUtils.CountVowels("Connall"));
    }
    [Fact]
    public static void StringCountConsonants()
    {
        int desiredOutcome = 5;
        Assert.Equal(desiredOutcome, StringUtils.CountConsonants("Connall"));
    }
    [Fact]
    public static void StringHasLetter()
    {
        bool desiredOutcome = false;
        Assert.Equal(desiredOutcome, StringUtils.HasLetter("Connall", 'e'));
    }
    [Fact]
    public static void StringFirstCaps()
    {
        string desiredOutcome = "Connall";
        Assert.Equal(desiredOutcome, StringUtils.CapsfirstLetter("connall"));
    }
    [Fact]
    public static void StringLastCaps()
    {
        string desiredOutcome = "connalL";
        Assert.Equal(desiredOutcome, StringUtils.CapslastLetter("connall"));
    }
    [Fact]
    public static void StringIsPalindrome(){
        bool desiredOutcome = true;
        Assert.Equal(desiredOutcome, StringUtils.IsPalindrome("Racecar"));
    }
    [Fact]
    public static void StringRemoveSpacesTest(){
        string desiredOutcome= "connall";
        Assert.Equal(desiredOutcome, StringUtils.StringRemoveSpaces("c o nna ll  "));
    }

    // Array

    [Fact]
    public static void Average()
    { Assert.Equal(3, Arrays.ArrayUtils.Average(new double[]{1.0, 2.0, 3.0, 4.0, 5.0})); }

    [Fact]
    public static void Max()
    { Assert.Equal(5, Arrays.ArrayUtils.Max(new int[]{1, 2, 3, 4, 5})); }

    [Fact]
    public static void Min()
    { Assert.Equal(1, Arrays.ArrayUtils.Min(new int[]{1, 2, 3, 4, 5})); }

    [Fact]
    public static void Sum()
    { Assert.Equal(15, Arrays.ArrayUtils.Sum(new int[]{1, 2, 3, 4, 5})); }

    [Fact]
    public static void Product()
    { Assert.Equal(120, Arrays.ArrayUtils.Product(new int[]{1, 2, 3, 4, 5})); }

    [Fact]
    public static void IsSymmetrical()
    { Assert.True(Arrays.ArrayUtils.IsSymmetrical(new int[]{1, 2, 3, 2, 1})); }

    [Fact]
    public static void GetIQR()
    { Assert.Equal(4, Arrays.ArrayUtils.GetIQR(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    [Fact]
    public static void GetQ3()
    { Assert.Equal(6.5, Arrays.ArrayUtils.GetQ3(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    [Fact]
    public static void GetQ1()
    { Assert.Equal(2.5, Arrays.ArrayUtils.GetQ1(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    [Fact]
    public static void GetNumberOfOutliers()
    { Assert.Equal(1, Arrays.ArrayUtils.GetNumberOfOutliers(new double[]{-8, 1, 2, 6, 7, 26})); }

    //Math

    [Fact]
    public static void GetNumerator()
    { Assert.Equal(567, Math.MathUtils.GetNumerator(9823.567)); }
}