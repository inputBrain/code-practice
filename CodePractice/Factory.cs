namespace CodePractice;

public static class Factory
{
    public static DigitalRootMain DigitalRoot() => new DigitalRootMain();

    public static Isogram Isogram() => new Isogram();

    public static Duplicate Duplicate() => new Duplicate();

    public static AlphabetPositionMain AlphabetPosition() => new AlphabetPositionMain();
}