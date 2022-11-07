using System.Text.RegularExpressions;

namespace Leetcode._1323_Maximum_69_Number;

public class Solution {
    //Alternate, regex method
    //public int Maximum69Number(int num) {
    //    Regex regex = new("6", RegexOptions.Compiled);
    //    return int.Parse(regex.Replace(num.ToString(), "9", 1));
    //}

    public int Maximum69Number(int num) {
        var number = num.ToString().ToList();
        var firstSix = number.IndexOf('6');

        if (firstSix < 0)
            return num;

        number[firstSix] = '9';
        return int.Parse(string.Join("", number));
    }
}
