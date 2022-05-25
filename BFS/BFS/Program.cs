using System;
using System.Collections.Generic;

namespace BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create elements
            var elementA = new TreeElement<int>(1);
            var elementB = new TreeElement<int>(3);
            var elementC = new TreeElement<int>(5);
            var elementD = new TreeElement<int>(4);
            var elementE = new TreeElement<int>(7);
            var elementF = new TreeElement<int>(2);
            var elementG = new TreeElement<int>(11);

            //connect elements
            elementA.Neighbors.Add(elementB);

            elementB.Neighbors.Add(elementA);
            elementB.Neighbors.Add(elementC);
            elementB.Neighbors.Add(elementD);
            elementB.Neighbors.Add(elementE);

            elementC.Neighbors.Add(elementB);
            elementC.Neighbors.Add(elementE);

            elementD.Neighbors.Add(elementB);
            elementD.Neighbors.Add(elementF);

            elementE.Neighbors.Add(elementB);
            elementE.Neighbors.Add(elementC);
            elementE.Neighbors.Add(elementF);
            elementE.Neighbors.Add(elementG);

            elementF.Neighbors.Add(elementD);
            elementF.Neighbors.Add(elementE);

            elementG.Neighbors.Add(elementE);

            var queue = new Queue<TreeElement<int>>();
            elementC.Level = 1;
            queue.Enqueue(elementC);
            //TraverseTreeBFS.Traverse(queue);

            Console.WriteLine("Other way");
            var traverseTreeBFSVer2 = new TraverseTreeBFSVer2<int>(elementC);
            traverseTreeBFSVer2.Traverse();
        }
    }
}