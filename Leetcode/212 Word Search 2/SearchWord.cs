namespace Leetcode._212_Word_Search_2;

public class SearchWord {
    private Trie _trie;
    private char[][] _board;
    private bool[,] _visited;
    public IList<string> FindWords(char[][] board, ReadOnlySpan<string> words) {
        _trie = new(words, '$');
        _board = board;
        _visited = new bool[board.Length, board[0].Length];

        HashSet<string> output = new();

        for (var r = 0; r < _board.Length; r++) {
            for (var c = 0; c < _board[r].Length; c++) {
                DFS(r, c, string.Empty, ref output);
            }
        }

        //Leetcode requires the IList interface, otherwise I would leave it as a hashset
        return output.ToList();
    }

    public void DFS(int row, int col, string q, ref HashSet<string> output) {
        //Guard for out of bound index or if the node has already been visited
        if (row < 0 || col < 0 || col >= _board[0].Length || row >= _board.Length || _visited[row, col])
            return;

        var sString = q + _board[row][col];

        if (_trie.StartsWith(sString))
            _visited[row, col] = true;
        else
            return;

        if (_trie.Search(sString)) {
            _trie.Remove(sString);
            _ = output.Add(sString);
        }

        DFS(row + 1, col, sString, ref output);
        DFS(row - 1, col, sString, ref output);
        DFS(row, col + 1, sString, ref output);
        DFS(row, col - 1, sString, ref output);

        _visited[row, col] = false;
    }
}