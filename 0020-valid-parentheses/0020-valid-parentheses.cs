public class Solution {
    public bool IsValid(string s) {
            Dictionary<char, char> di = new Dictionary<char, char>
            {
                {'{',  '}'},
                {'(',  ')'},
                {'[',  ']'},
            };

            Stack<char> stack = new Stack<char>();

            foreach (char input in s)
            {
                if (di.ContainsKey(input))
                {
                    stack.Push(input);
                }
                else
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }
                    if (di[stack.Pop()] == input)
                    {
                        continue;
                    }
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }