public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> st = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int num))
            {
                st.Push(num);
            }
            else
            {
                int right = st.Pop();
                int left = st.Pop();

                switch (token)
                {
                    case "+":
                        st.Push(left + right);
                        break;

                    case "-":
                        st.Push(left - right);
                        break;

                    case "*":
                        st.Push(left * right);
                        break;

                    case "/":
                        st.Push(left / right);
                        break;
                }
            }
        }

        return st.Pop();
    }
}