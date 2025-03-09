namespace LeetCode.Easy._1323_Maximum_69_Number;

public class Solution {
    //Alternate, regex method
    //public int Maximum69Number(int num) {
    //    Regex regex = new("6", RegexOptions.Compiled);
    //    return int.Parse(regex.Replace(num.ToString(), "9", 1));
    //}

    //public int Maximum69Number(int num) {
    //    var number = num.ToString().ToList();
    //    var firstSix = number.IndexOf('6');

    //    if (firstSix < 0)
    //        return num;

    //    number[firstSix] = '9';
    //    return int.Parse(string.Join("", number));
    //}

    //Runtime beats 85.71%
    //Memory  beats 91.67%
    public int Maximum69Number(int num) {
        var number = num.ToString().ToCharArray();
        var i = 0;

        for (; i < number.Length; i++) {
            if (number[i] == '6') {
                number[i] = '9';
                break;
            }
        }

        return i == number.Length ? num : int.Parse(number);
    }
}
