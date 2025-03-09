using System.Text;

namespace LeetCode.Hard._899_Orderly_Que;

public class Solution {
    public string OrderlyQueue(string s, int k) {
        if (s.Length == 1)
            return s; //nothing we can do if there is only one char

        if (k == 1) { //if k is 1, then you can only rotate the array.
            var min = s.Min();
            if (s.LastIndexOf(min) != s.IndexOf(min)) {
                //if there is more than one min char
                //find all of the indexes
                List<string> sList = new();

                if (s.IndexOf(min) == 0)
                    sList.Add(s);
                for (var i = 1; i < s.Length; i++)
                    if (s[i] == min)
                        sList.Add(s.Substring(i, s.Length - i) + s.Substring(0, i));

                return sList.Min()!;
            }

            return s.Substring(s.IndexOf(min)) + s.Substring(0, s.IndexOf(min));
        }

        if (k > 2) //if k>2, than you can do ops that sort the entire array.
            return string.Join("", s.OrderBy(x => x));

        //if k==2, the array is sorted, except for the last k chars.
        //They are in the order that they appear in string s 

        var sorted = s.OrderBy(x => x).ToList();
        PriorityQueue<char, int> q = new();

        StringBuilder sb = new(s.Length);

        for (var i = 0; i < s.Length - s.Length % k; i++) sb.Append(sorted.ElementAt(i));

        for (var i = sb.Length; i < sb.Length + s.Length % k; i++) q.Enqueue(sorted[i], s.LastIndexOf(sorted[i]));

        while (q.Count > 0)
            sb.Append(q.Dequeue());

        return sb.ToString();
    }
}