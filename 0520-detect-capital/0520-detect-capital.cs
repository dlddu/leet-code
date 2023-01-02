public class Solution {
    public bool DetectCapitalUse(string word) {
        if (word.Length == 1) return true;
        
        var firstCharacter = word.First();
        
        if (char.IsUpper(firstCharacter))
            return word.Skip(1).All(ch => char.IsUpper(ch)) || word.Skip(1).All(ch => char.IsLower(ch));
        else
            return word.Skip(1).All(ch => char.IsLower(ch));
    }
}