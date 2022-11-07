namespace Leetcode._1323_Maximum_69_Number;

public class Solution {
    public int Maximum69Number(int num) {
        //could do a regex replace aswell.
        var number = num.ToString().ToList();
        var firstSix = number.IndexOf('6');

        if (firstSix < 0)
            return num;

        number[firstSix] = '9';
        return int.Parse(string.Join("", number));
    }
}
