using SimpleTreeNode;
using System;

namespace CheckNumberOccurences
{
    internal class Program
    {
        static int target;
        static int count;
        static void Main(string[] args)
        {
            target = int.Parse(Console.ReadLine());
            count = 0;
            TreeNode<int> tree = new TreeNode<int>(1,
                new TreeNode<int>(1,
                    new TreeNode<int>(8),
                    new TreeNode<int>(1)
                    ),
                new TreeNode<int>(7,
                    new TreeNode<int>(8)
                    ),
                new TreeNode<int>(7,
                    new TreeNode<int>(5),
                    new TreeNode<int>(3)
                    )
                );

            CountOccurence(tree);
        }

        private static void CountOccurence(TreeNode<int> tree)
        {
            DFS(tree);

            if (count == 0)
                Console.WriteLine($"Element {target} doesn’t exist in the tree.");
            else
                Console.WriteLine($"Element {target} occurs {count} times.");
        }

        static void DFS(TreeNode<int> node)
        {
            if (node.Value == target)
                count++;

            foreach (var child in node.ChildNodes)
            {
                DFS(child);
            }
        }
    }
}
