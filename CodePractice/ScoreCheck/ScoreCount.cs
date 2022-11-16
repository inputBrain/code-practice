using System.Collections.Generic;

namespace CodePractice.ScoreCheck;

// Three 1's => 1000 points
// Three 6's =>  600 points
// Three 5's =>  500 points
// Three 4's =>  400 points
// Three 3's =>  300 points
// Three 2's =>  200 points
// One   1   =>  100 points
// One   5   =>   50 point
public class ScoreCount
{
    public static int ProcessScoreCount(int[] scores)
    {
        var totalScore = 0;
        
        var ones = new List<int>();
        var twos = new List<int>();
        var threes = new List<int>();
        var fours = new List<int>();
        var fives = new List<int>();
        var sixs = new List<int>();

        foreach (var score in scores)
        {
            if (score % 1 == 0)
            {
                ones.Add(score);
            }

            if (score % 2 == 0)
            {
                twos.Add(score);
            }

            if (score % 3 == 0)
            {
                threes.Add(score);
            }

            if (score % 4 == 0)
            {
                fours.Add(score);
            }

            if (score % 5 == 0)
            {
                fives.Add(score);
            }

            if (score % 6 == 0)
            {
                sixs.Add(score);
            }
        }


        switch (ones.Count)
        {
            case 1:
                totalScore += 100;
                break;
            case 3:
                totalScore += 1000;
                break;
        }

        if (twos.Count == 3)
        {
            totalScore += 200;
        }

        if (threes.Count == 3)
        {
            totalScore += 300;
        }

        if (threes.Count == 2)
        {
            totalScore += 200;
        }

        if (fours.Count == 3)
        {
            totalScore += 400;
        }

        switch (fives.Count)
        {
            case 3:
                totalScore += 500;
                break;
            case 1:
                totalScore += 50;
                break;
        }

        if (sixs.Count == 3)
        {
            totalScore += 600;
        }

        Console.WriteLine(totalScore);

        return totalScore;
    }
    
}