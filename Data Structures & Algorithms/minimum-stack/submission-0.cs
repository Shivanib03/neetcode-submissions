public class MinStack {

    public Stack<int> stack;
    public Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.TryPeek(out int n))
        {
            if(val <= n)
            {
                minStack.Push(val);
            }
        }
        else
            minStack.Push(val);
    }
    
    public void Pop() {
        if(stack.Peek() == minStack.Peek())
        {
            minStack.Pop();
        }
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        if(stack.TryPeek(out int n) && minStack.TryPeek(out int m))
        {
            if(m <= n)
            {
                return m;
            }
            else
            {
                minStack.Push(n);
                return n;
            }
        }
        else
            return stack.Peek();
    }
}
