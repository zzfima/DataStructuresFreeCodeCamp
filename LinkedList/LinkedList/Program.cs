﻿using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListCustom<int> linkedListCustom = new LinkedListCustom<int>();
            linkedListCustom.Add(5);
            linkedListCustom.Add(6);
            linkedListCustom.Add(7);
            linkedListCustom.Add(8);

            foreach (var v in linkedListCustom)
            {
                Console.WriteLine(v);
            }
        }
    }
}