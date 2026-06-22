public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new Stack<char>();
        List<char> open = new List<char>() { '(', '{', '['};
        List<char> closed = new List<char>() { ')', '}', ']'};
        if(s.Length % 2 != 0)
            return false;
        foreach(char c in s)
        {
            if(closed.Contains(c))
                if(st.Count == 0)
                    return false;
                else
                {
                    char popped = st.Pop();
                    if(c == ']' && popped != '[')    
                        return false;
                    if(c == '}' && popped != '{')    
                        return false;
                    if(c == ')' && popped != '(')    
                        return false;
                }
            else
                st.Push(c);
        }
        return st.Count == 0;
    }
}
