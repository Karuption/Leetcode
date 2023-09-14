using System.Text;

namespace Leetcode.Hard._68_Text_Justification; 

public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        int start = 0;
        int wordCount = 0;
        int spaceCount = 0;
        int charCount = 0;

        List<string> output = new();
        StringBuilder line = new();

        while(true) {
            start = start + wordCount;
            wordCount = spaceCount = charCount = 0;

            for(int i = start; i < words.Length; i++) {
                if(charCount + words[i].Length > maxWidth) {
                    break;
                } else {
                    wordCount++;
                    charCount += words[i].Length;
                    if(charCount < maxWidth) {
                        spaceCount++;
                        charCount++;
                    }
                }
            }

            spaceCount += maxWidth - charCount;

            // if the last line in the output
            if(start + wordCount == words.Length) {
                charCount = 0;
                for(int i = start; i < words.Length; i++) {
                    line.Append(words[i]);
                    charCount += words[i].Length;
                    if(charCount++ < maxWidth)
                        line.Append(" ");
                }

                while(charCount++ < maxWidth)
                    line.Append(" ");
                output.Add(line.ToString());
                break;
            }

            //proccess line
            for(int i = start; i < start + wordCount; i++) {
                line.Append(words[i]);
                
                if(wordCount == 1){
                    line.Append(new String(' ', spaceCount));
                    break;
                }

                int wordsLeft = start + wordCount - i;
                if(wordsLeft < 2)
                    break;

                int spaces = (spaceCount/(wordsLeft-1)) + (spaceCount%(wordsLeft-1)>0?1:0);
                for(int j = 0; j < spaces ; j++) {
                    spaceCount--;
                    line.Append(" ");
                }
            }
            output.Add(line.ToString());
            line.Clear();
        }

        return output;
    }
}