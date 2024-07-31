namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("([])"));
        }

        public static bool IsValid(string s)
        {
            if(s.Length % 2 != 0) return false;

            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' && stack.Count != 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (c == ']' && stack.Count != 0 && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else if (c == '}' && stack.Count != 0 && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else return false;
            }
            return stack.Count == 0;
        }
    }
}
