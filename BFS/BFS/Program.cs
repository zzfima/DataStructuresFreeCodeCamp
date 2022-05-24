using System.Collections.Generic;

namespace BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create elements
            TreeElement<int> elementA = new TreeElement<int>(1);
            TreeElement<int> elementB = new TreeElement<int>(3);
            TreeElement<int> elementC = new TreeElement<int>(5);
            TreeElement<int> elementD = new TreeElement<int>(4);
            TreeElement<int> elementE = new TreeElement<int>(7);
            TreeElement<int> elementF = new TreeElement<int>(2);
            TreeElement<int> elementG = new TreeElement<int>(11);

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

            Queue<TreeElement<int>> queue = new Queue<TreeElement<int>>();
            elementC.Level = 1;
            queue.Enqueue(elementC);
            TraverseTreeBFS.Traverse(queue);
        }
    }
}