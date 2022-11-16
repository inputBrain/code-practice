// using CodePractice;
// using Xunit;
//
// namespace CodeTest;
//
// public class CodeTest : AbstractCaseTest
// {
//     [Fact]
//     public void IsogramTest()
//     {
//         var isogram = _serviceContainer.Isogram.IsIsogram("moOse");
//
//         var isIsogram = isogram.IsIsogram("moOse");
//         var bestPractices = isogram.BestPractices("moOse");
//         
//         Assert.False(isIsogram);
//         Assert.False(bestPractices);
//     }
//
//     [Fact]
//     public void DigitalRootTest()
//     {
//         var digital = Factory.DigitalRoot();
//
//         var result = digital.DigitalRoot(16);
//         Assert.Equal(7, result);
//
//         result = digital.DigitalRoot(942);
//         Assert.Equal(6, result);
//
//         result = digital.DigitalRoot(132189);
//         Assert.Equal(6, result);
//
//         result = digital.DigitalRoot(493193);
//         Assert.Equal(2, result);
//
//         var bestPractices = digital.BestPractices(493193);
//         Assert.Equal(2, bestPractices);
//     }
//
//     [Fact]
//     public void DuplicateCountTest()
//     {
//         var duplicate = Factory.Duplicate();
//
//         var count = duplicate.CountDuplicateLettersInText("Indivisibility");
//         Assert.Equal(1, count);
//     }
// }