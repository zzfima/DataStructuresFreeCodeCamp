using System;
using System.Collections.Generic;

namespace BracketsCheck
{
    internal class BracketsChecker
    {
        public bool Check(char[] brackets)
        {
            Stack<char> bracketsStack = new Stack<char>();

            foreach (var bracket in brackets)
            {
                //its left - insert it
                if (IsLeftBracket(bracket))
                    bracketsStack.Push(bracket);
                //its right - pop and compare
                else
                {
                    if (bracketsStack.Count == 0)
                        return false;
                    char b = bracketsStack.Pop();

                    if (!IsComplementaryBrackets(b, bracket))
                        return false;
                }
            }

            if (bracketsStack.Count != 0)
                return false;

            return true;
        }

        private bool IsComplementaryBrackets(char leftBracket, char rightBracket)
        {
            if (leftBracket == '(' && rightBracket == ')')
                return true;
            if (leftBracket == '[' && rightBracket == ']')
                return true;
            return false;
        }

        private bool IsLeftBracket(char bracket)
        {
            if (bracket == '(' || bracket == '[')
                return true;
            return false;
        }
    }
}