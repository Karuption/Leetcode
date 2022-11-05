using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._212_Word_Search_2;
public class SearchWord
{
    private Trie _trie;
    private char[][] _board;
    private bool[,] _visited;
    public IList<string> FindWords(char[][] board, ReadOnlySpan<string> words) {
        _trie = new(words);
        _board = board;
        _visited = new bool[board.Length, board[0].Length];

        HashSet<string> output = new ();
        List<string> temp;
        for (int r = 0; r < _board.Length; r++) {
            for (int c = 0; c < _board[r].Length; c++) {
                temp = DFS(r, c, String.Empty);
                if (temp!=null) {
                    output.UnionWith(temp);
                    temp = null;
                }
            }
        }

        return output.OrderBy(x=>x).ToList();
    }

    public List<string>? DFS(int row, int col, string q) {
        if (row >= _board.Length || row < 0 || col >= _board[0].Length || col < 0 || _visited[row, col])
            return null;

        string sString = q + _board[row][col];

        if (_trie.StartsWith(sString))
            _visited[row, col] = true;
        else
            return null;


        List<string> output = new();

        if (_trie.Search(sString)) {
            _trie.Remove(sString);
            output.Add(sString);
        }

        //recursive 
        List<string> temp;

        temp = DFS(row + 1, col, sString);
        if (temp!= null)
            output.AddRange(temp);

        temp = DFS(row - 1, col, sString);
        if (temp!= null)
            output.AddRange(temp);

        temp = DFS(row, col + 1, sString);
        if (temp!= null) 
            output.AddRange(temp);

        temp = DFS(row, col - 1, sString);
        if (temp!= null) 
            output.AddRange(temp);

        _visited[row, col] = false;
        return (output.Count==0)?null:output;
    }
}