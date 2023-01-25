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

    //
}