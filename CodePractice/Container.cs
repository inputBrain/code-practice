namespace CodePractice;

public class Container : IContainer
{
    public AlphabetPositionMain AlphabetPositionMain { get; }

    public DigitalRootMain DigitalRootMain { get; }

    public Duplicate Duplicate { get; }

    public Isogram Isogram { get; }

    public Container(
        AlphabetPositionMain alphabetPositionMain,
        DigitalRootMain digitalRootMain,
        Duplicate duplicate,
        Isogram isogram
    )
    {
        AlphabetPositionMain = alphabetPositionMain;
        DigitalRootMain = digitalRootMain;
        Duplicate = duplicate;
        Isogram = isogram;
    }
}