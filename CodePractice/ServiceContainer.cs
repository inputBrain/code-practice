using CodePractice.Algorithm;
using CodePractice.Alphabet;
using CodePractice.CheckCode;
using CodePractice.InterestingCode;
using CodePractice.Reverse;

namespace CodePractice;

public sealed class ServiceContainer
{
    public readonly Duplicate Duplicate;
    public readonly Isogram Isogram;
    public readonly DigitalRootMain DigitalRootMain;

    public readonly AlphabetManipulation AlphabetManipulation;

    public readonly ExcludeString ExcludeString;

    public readonly DrawStars DrawStars;
    public readonly ToSnakeCase ToSnakeCase;

    public readonly ReverseText ReverseText;

    public ServiceContainer(
        Duplicate duplicate,
        Isogram isogram,
        DigitalRootMain digitalRootMain,
        AlphabetManipulation alphabetManipulation,
        ExcludeString excludeString,
        DrawStars drawStars,
        ToSnakeCase toSnakeCase,
        ReverseText reverseText
    )
    {
        Duplicate = duplicate;
        Isogram = isogram;
        DigitalRootMain = digitalRootMain;
        AlphabetManipulation = alphabetManipulation;
        ExcludeString = excludeString;
        DrawStars = drawStars;
        ToSnakeCase = toSnakeCase;
        ReverseText = reverseText;
    }
}