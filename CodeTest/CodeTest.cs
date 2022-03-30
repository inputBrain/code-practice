using CodePractice;
using Xunit;

namespace CodeTest;

public class CodeTest
{
    [Fact]
    public void IsogramTest()
    {
        var isogram = Factory.Isogram();

        var isIsogram = isogram.IsIsogram("moOse");
        var bestPractices = isogram.BestPractices("moOse");
        
        Assert.False(isIsogram);
        Assert.False(bestPractices);
    }

    [Fact]
    public void DigitalRootTest()
    {
        var digital = Factory.DigitalRoot();

        var result = digital.DigitalRoot(16);
        Assert.Equal(7, result);

        result = digital.DigitalRoot(942);
        Assert.Equal(6, result);

        result = digital.DigitalRoot(132189);
        Assert.Equal(6, result);

        result = digital.DigitalRoot(493193);
        Assert.Equal(2, result);

        var bestPractices = digital.BestPractices(493193);
        Assert.Equal(2, bestPractices);
    }

    [Fact]
    public void DuplicateCountTest()
    {
        var duplicate = Factory.Duplicate();

        var count = duplicate.DuplicateCount("Indivisibility");
        Assert.Equal(1, count);


    }

    [Fact]
    public void AlphabetPositionTest()
    {
        var alphabetPosition = Factory.AlphabetPosition();
        
        var text = "The sunset sets at twelve o' clock.";
        
        var result = alphabetPosition.AlphabetPosition(text);
        
        Assert.Equal("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", result);
    }
}