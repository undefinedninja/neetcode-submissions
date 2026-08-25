public class MinStack {

    int min = int.MaxValue;
    List<int> stack = null;
    public MinStack() {
         stack = new List<int>();
    }
    
    public void Push(int val) {
        if(this.min > val)
            this.min = val;
        stack.Add(val);
    }
    
    public void Pop() {
        int length = stack.Count;
        int val = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        if(this.min == val)
        {
            int newMin = int.MaxValue;
            foreach(int i in stack)
            {
                if(newMin > i)
                    newMin = i;
            }
            this.min = newMin;
        }
    }
    
    public int Top() {
        return stack[stack.Count - 1];
    }
    
    public int GetMin() {
        return this.min;
    }
}
