public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        if (sentence.StartsWith(searchWord))
            return 1;
        var index = sentence.IndexOf(" " + searchWord);
        if (index == -1) return -1;
        var spaces = sentence.Substring(0, index + 1).Count(ch => ch == ' ');
        return spaces + 1;
    }
}