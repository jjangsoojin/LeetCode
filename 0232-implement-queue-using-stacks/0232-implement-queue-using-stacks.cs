public class MyQueue {
/*
스택으로 큐를 구현해야함 - 스택은 LIFO ,  큐는 FIFO
stack1,stack2 를 선언해서 stack1 > stack 2 로 큐 작동방식(FIFO)처럼 만들어 줘야함
*/
     
     private Stack<int> stack1; // 스택 1
     private Stack<int> stack2; // 스택 2
     

    /** 데이터 구조를 초기화 */
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
     
     /** 큐의 뒤쪽에 원소 x를 추가합니다. */ 
    public void Push(int x) {
        stack1.Push(x);
    }

     /** 큐의 앞쪽에서 원소를 제거하고 해당 원소를 반환합니다. */
    public int Pop() {
        if(stack2.Count == 0){
            while(stack1.Count > 0){
                stack2.Push(stack1.Pop());             /** stack1의 모든 원소를 stack2로 옮기는 작업 */
            }
        }
         return stack2.Pop();
    }
     
     /** 큐의 앞쪽에 있는 원소를 반환합니다. */
    public int Peek() {
        if(stack2.Count == 0){
            while(stack1.Count > 0){
                stack2.Push(stack1.Pop());             /** stack1의 모든 원소를 stack2로 옮기는 작업 */
            }
        }
        return stack2.Peek();
    }
     
     /** 큐가 비어있는지 여부를 반환합니다. */
    public bool Empty() {
        return stack2.Count == 0 && stack1.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
