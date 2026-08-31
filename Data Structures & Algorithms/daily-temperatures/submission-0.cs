public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Stack<int[]> st =  new Stack<int[]>();
        for(int i = 0; i < temperatures.Length; i++)
        {
            while(st.Count > 0 && temperatures[i] > st.Peek()[0])
            {
                int[] pair = st.Pop();
                res[pair[1]] = i  - pair[1];
            }
            st.Push(new int[] {temperatures[i], i});
        }
        return res;
    }
}
