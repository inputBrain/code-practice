using CodePractice.Algorithm;
using CodePractice.Alphabet;
using CodePractice.CheckCode;
using CodePractice.InterestingCode;
using CodePractice.Reverse;

namespace CodePractice;

public class Facade : IFacade
{
    public ServiceContainer ServiceContainer { get; }

    public Facade()
    {
        ServiceContainer = new ServiceContainer(
            new Duplicate(),
            new Isogram(),
            new DigitalRootMain(),
            new AlphabetManipulation(),
            new ExcludeString(),
            new DrawStars(),
            new ToSnakeCase(),
            new ReverseText()
        );
    }
}