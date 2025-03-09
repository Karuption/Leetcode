namespace LeetCode.Medium._71_Simplify_Path; 

public class Solution {
    public string SimplifyPath(string path) {
        var dirs = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        Stack<string> stack = new(dirs.Length);


        foreach (var dir in dirs) {
            if (dir == ".")
                continue;

            if (dir == "..") { 
                stack.TryPop(out _);
                continue;
            }
            stack.Push(dir);
        }

        return "/" + string.Join("/", stack.Reverse());
    }
}