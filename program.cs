using System;
using System.Collections.Generic;

public class Solution
{
  public bool IsValid(string s)
  {
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

    foreach (char c in s)
    {
      if (bracketPairs.ContainsKey(c))
      {
        // If it's an opening bracket, push it onto the stack.
        stack.Push(c);
      }
      else
      {
        // If it's a closing bracket, check if it matches the top of the stack.
        if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
        {
          return false; // Invalid, as the brackets don't match.
        }
      }
    }

    return stack.Count == 0; // If the stack is empty, it's valid.
  }

  public static void Main(string[] args)
  {
    Solution solution = new Solution();
    Console.WriteLine(solution.IsValid("()")); // Output: True
    Console.WriteLine(solution.IsValid("()[]{}")); // Output: True
    Console.WriteLine(solution.IsValid("(]")); // Output: False
  }
}
