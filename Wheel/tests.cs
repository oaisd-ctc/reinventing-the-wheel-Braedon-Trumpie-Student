using Xunit;
using String;
using Math;
using Arrays;
public static class Tests
{

    //String
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
    public static void StringLength()
    {
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
    public static void StringIsPalindrome()
    {
        bool desiredOutcome = true;
        Assert.Equal(desiredOutcome, StringUtils.IsPalindrome("Racecar"));
    }
    [Fact]
    public static void StringRemoveSpacesTest()
    {
        string desiredOutcome = "connall";
        Assert.Equal(desiredOutcome, StringUtils.StringRemoveSpaces("c o nna ll  "));
    }


    //Math
    [Fact]
    public static void TestAddInt()
    {
        int desiredOutcome = 17;
        Assert.Equal(desiredOutcome, MathUtils.Add(13, 4));
    }
    [Fact]
    public static void TestAddDouble()
    {
        double desiredOutcome = 23.54;
        Assert.Equal(desiredOutcome, MathUtils.Add(17.5, 6.04));
    }
    [Fact]
    public static void TestAddFloat()
    {
        float desiredOutcome = 23.54f;
        Assert.Equal(desiredOutcome, MathUtils.Add(17f, 6.54f));
    }
    [Fact]
    public static void TestSubtractInt()
    {
        int desiredOutcome = 6;
        Assert.Equal(desiredOutcome, MathUtils.Subtract(12, 6));
    }
    [Fact]
    public static void TestSubtractDouble()
    {
        double desiredOutcome = 6.65;
        Assert.Equal(desiredOutcome, MathUtils.Subtract(12.65, 6));
    }
    [Fact]
    public static void TestSubtractFloat()
    {
        float desiredOutcome = 6f;
        Assert.Equal(desiredOutcome, MathUtils.Subtract(12, 6));
    }
    //Multiplicaton
    [Fact]
    public static void TestMultiplyInt()
    {
        int desiredOutcome = 72;
        Assert.Equal(desiredOutcome, MathUtils.Multiply(12, 6));
    }
    [Fact]
    public static void TestMultiplyDouble()
    {
        double desiredOutcome = 72.0;
        Assert.Equal(desiredOutcome, MathUtils.Multiply(12, 6));
    }
    [Fact]
    public static void TestMultiplyFloat()
    {
        float desiredOutcome = 72f;
        Assert.Equal(desiredOutcome, MathUtils.Multiply(12, 6f));
    }
    //Divison
    [Fact]
    public static void TestDivideInt()
    {
        int desiredOutcome = 2;
        Assert.Equal(desiredOutcome, MathUtils.Divide(12, 6));
    }
    [Fact]
    public static void TestDivideDouble()
    {
        Double desiredOutcome = 2;
        Assert.Equal(desiredOutcome, MathUtils.Divide(12, 6));
    }
    [Fact]
    public static void TestDivideFloat()
    {
        float desiredOutcome = 2f;
        Assert.Equal(desiredOutcome, MathUtils.Divide(12, 6));
    }
    //Max
    [Fact]
    public static void TestMaxInt()
    {
        int desiredOutcome = 3;
        Assert.Equal(desiredOutcome, MathUtils.Max(3, 1));
    }
    [Fact]
    public static void TestMaxDouble()
    {
        double desiredOutcome = 3;
        Assert.Equal(desiredOutcome, MathUtils.Max(3, 1));
    }
    [Fact]
    public static void TestMaxFloat()
    {
        float desiredOutcome = 3;
        Assert.Equal(desiredOutcome, MathUtils.Max(3, 1));
    }
    //Min
    [Fact]
    public static void TestMinInt()
    {
        int desiredOutcome = 1;
        Assert.Equal(desiredOutcome, MathUtils.Min(3, 1));
    }
    [Fact]
    public static void TestMinDouble()
    {
        double desiredOutcome = 1;
        Assert.Equal(desiredOutcome, MathUtils.Min(3, 1));
    }
    [Fact]
    public static void TestMinFloat()
    {
        float desiredOutcome = 1;
        Assert.Equal(desiredOutcome, MathUtils.Min(3, 1));
    }
    [Fact]
    public static void TestAbsValDouble()
    {
        double desiredOutcome = 10;
        Assert.Equal(desiredOutcome, MathUtils.AbsoluteValue(-10));
    }
    [Fact]
    public static void TestAbsValFloat()
    {
        float desiredOutcome = 10;
        Assert.Equal(desiredOutcome, MathUtils.AbsoluteValue(-10));
    }
    [Fact]
    public static void TestSalesTaxDouble()
    {
        double desiredOutcome = 1.06;
        Assert.Equal(desiredOutcome, MathUtils.salesTax(1, 0.06));
    }
    [Fact]
    public static void TestSalesTaxFloat()
    {
        float desiredOutcome = 1.0600000000000001f;
        Assert.Equal(desiredOutcome, MathUtils.salesTax(1, 0.06f));
    }

    // Array

    // [Fact]
    // public static void Average()
    // { Assert.Equal(3, Arrays.ArrayUtils.Average(new double[]{1.0, 2.0, 3.0, 4.0, 5.0})); }

    // [Fact]
    // public static void Max()
    // { Assert.Equal(5, Arrays.ArrayUtils.Max(new int[]{1, 2, 3, 4, 5})); }

    // [Fact]
    // public static void Min()
    // { Assert.Equal(1, Arrays.ArrayUtils.Min(new int[]{1, 2, 3, 4, 5})); }

    // [Fact]
    // public static void Sum()
    // { Assert.Equal(15, Arrays.ArrayUtils.Sum(new int[]{1, 2, 3, 4, 5})); }

    // [Fact]
    // public static void Product()
    // { Assert.Equal(120, Arrays.ArrayUtils.Product(new int[]{1, 2, 3, 4, 5})); }

    // [Fact]
    // public static void IsSymmetrical()
    // { Assert.True(Arrays.ArrayUtils.IsSymmetrical(new int[]{1, 2, 3, 2, 1})); }

    // [Fact]
    // public static void GetIQR()
    // { Assert.Equal(4, Arrays.ArrayUtils.GetIQR(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    // [Fact]
    // public static void GetQ3()
    // { Assert.Equal(6.5, Arrays.ArrayUtils.GetQ3(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    // [Fact]
    // public static void GetQ1()
    // { Assert.Equal(2.5, Arrays.ArrayUtils.GetQ1(new double[]{1, 2, 3, 4, 5, 6, 7, 26})); }

    // [Fact]
    // public static void GetNumberOfOutliers()
    // { Assert.Equal(1, Arrays.ArrayUtils.GetNumberOfOutliers(new double[]{-8, 1, 2, 6, 7, 26})); }

    // //Math

    // [Fact]
    // public static void GetNumerator()
    // { Assert.Equal(87923, Math.MathUtils.GetNumerator(4.87923)); }

    // [Fact]
    // public static void SimplifiedNumerator()
    // { Assert.Equal(1, Math.MathUtils.SimplifiedNumerator(4.125)); }

    // [Fact]
    // public static void SimplifiedDenominator()
    // { Assert.Equal(8, Math.MathUtils.SimplifiedDenominator(4.125)); }

    // [Fact]
    // public static void Root()
    // { Assert.Equal(2, Math.MathUtils.Root(128, 7)); }

    // [Fact]
    // public static void Power()
    // { Assert.Equal(3.7845997273, Math.MathUtils.Power(11.76, .54)); }
}