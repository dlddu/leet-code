public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        foreach (var (word, index) in sentence.Split().Select((word, index) => (word, index)))
            if (word.StartsWith(searchWord))
                return index + 1;
        
        return -1;
    }
}