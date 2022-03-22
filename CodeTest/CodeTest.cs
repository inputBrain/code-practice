using System.Threading.Tasks;
using CodeCodewars;
using Xunit;

namespace CodeTest;

public class CodeTest
{
    
    [Fact]
    public async Task OkTest()
    {
        var isogram = new Isogram();
        
        var isIsogram = isogram.IsIsogram("moOse");
        Assert.False(isIsogram);
    }
}