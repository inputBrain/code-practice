﻿// See https://aka.ms/new-console-template for more information

// int DigitalRoot(long n)
// {
    // var cArr = n.ToString().ToCharArray();

    // var num = cArr.Sum(c => long.Parse(c.ToString()));

    // Console.WriteLine(num);
    // return 0;
// } ok





// 16  -->  1 + 6 = 7
// 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
// 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
// 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

DigitalRoot(493193);

int DigitalRoot(long n)
{
    var cArr = n.ToString().ToCharArray();

    long updatedLong = 0;
    
    foreach (var c in cArr)
    {
        updatedLong += long.Parse(c.ToString());
    }

    if (updatedLong >= 10)
    {
        var newLong = updatedLong.ToString().ToCharArray();
        
        updatedLong = 0;
        
        foreach (var c in newLong)
        {
            
            updatedLong += long.Parse(c.ToString());
        }

        if (updatedLong >= 10)
        {
            DigitalRoot(updatedLong);
        }
    }
    
    return int.Parse(updatedLong.ToString());
}