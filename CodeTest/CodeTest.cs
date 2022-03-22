using CodePractice;
using Xunit;

namespace CodeTest;

public class CodeTest
{
    [Fact]
    public void OkTest()
    {
        var isogram = Factory.Isogram();

        var isIsogram = isogram.IsIsogram("moOse");
        var bestPractices = isogram.IsIsogram("moOse", true);
        
        Assert.False(isIsogram);
        Assert.False(bestPractices);
    }
}