namespace LeetCode.Easy._374_Guess_Number_Higher_or_Lower;

/**
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 * 1 if num is lower than the picked number
 * otherwise return 0
 * int guess(int num);
 */
public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var lowerBound = 1;
        var upperBound = n;
        var _guess = 0;
        var gOutput = -1; //-1 is chosen to not interfere with the loop checking the output

        while (gOutput != 0) {
            _guess = (upperBound - lowerBound) / 2 + lowerBound;

            gOutput = guess(_guess);

            if (gOutput == 1)
                lowerBound = _guess + 1;
            else
                upperBound = _guess - 1;
        }

        return _guess;
    }
}

//This class is provided by Leetcode internals.
//This is only present to remove errors
public abstract class GuessGame {
    public int guess(int x) {
        return 1;
    }
}