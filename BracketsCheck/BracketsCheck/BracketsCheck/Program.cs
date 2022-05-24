using System;

namespace BracketsCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BracketsChecker bracketsChecker = new BracketsChecker();
            Console.WriteLine(bracketsChecker.Check(new char[] { '(', '[', ']', '[', ']', ')' }));
            Console.WriteLine(bracketsChecker.Check(new char[] { '(', '[', ']', '[', ']', ']' }));
            Console.WriteLine(bracketsChecker.Check(new char[] { '(', '[', ']', '[', ']' }));
        }
    }
}