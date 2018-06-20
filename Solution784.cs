public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        IList<string> resultList = new List<string>();
        if (S.Length == 0)
        {
            resultList.Add("");
            return resultList;
        }
        LetterCasePermutationHelper(S, 0, resultList);
        return resultList;
    }
    
    public void LetterCasePermutationHelper(string s, int index, IList<string> resultList)
    {
        if (index == s.Length)
        {
            resultList.Add(s);
            return;
        }
        
        if (char.IsLetter(s[index]))
        {
            string newS = s.Substring(0,index) + (char.IsLower(s[index]) ? char.ToUpper(s[index]) : char.ToLower(s[index])) + s.Substring(index+1, s.Length-index-1);
            LetterCasePermutationHelper(newS, index+1, resultList);
        }
        LetterCasePermutationHelper(s, index+1, resultList);

    }
}