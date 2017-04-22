import java.util.*;

interface IntStack {
    void push(int n);
    int pop();
}

public class MyStack implements IntStack {
    private ArrayList<Integer> stack = new ArrayList<Integer>();

    public void push(int n) {
        stack.add(n);
    }

    public int pop() {
        return stack.remove(stack.size() - 1);
    }

    public static void main(String[] args) {
        IntStack myStack = new MyStack();

        myStack.push(20);
        System.out.println(myStack.pop());
        myStack.push(20);
        System.out.println(myStack.pop());
        myStack.push(20);
        myStack.push(21);
        System.out.println(myStack.pop());
    }
}