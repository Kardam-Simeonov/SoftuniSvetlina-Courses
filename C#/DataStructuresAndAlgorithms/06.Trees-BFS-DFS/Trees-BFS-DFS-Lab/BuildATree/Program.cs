using SimpleTreeNode;
using System;

namespace BuildATree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode<char> treeOne = new TreeNode<char>('A',
                new TreeNode<char>('B',
                    new TreeNode<char>('D',
                        new TreeNode<char>('H'),
                        new TreeNode<char>('I')
                        ),
                    new TreeNode<char>('E')
                    ),
                new TreeNode<char>('C',
                    new TreeNode<char>('F',
                        new TreeNode<char>('J')
                        ),
                    new TreeNode<char>('G')
                    )
                );
          
            TreeNode<int> treeTwo = new TreeNode<int>(25,
                new TreeNode<int>(20,
                    new TreeNode<int>(10,
                        new TreeNode<int>(5,
                            new TreeNode<int>(1),
                            new TreeNode<int>(8)
                            ),
                        new TreeNode<int>(12,
                            new TreeNode<int>(15)
                            )
                        ),
                    new TreeNode<int>(22)
                    ),
                new TreeNode<int>(36,
                    new TreeNode<int>(30,
                        new TreeNode<int>(28)
                        ),
                    new TreeNode<int>(40,
                        new TreeNode<int>(38),
                        new TreeNode<int>(48,
                            new TreeNode<int>(45),
                            new TreeNode<int>(50)
                            )
                        )
                    )
                );

            Console.WriteLine(treeOne);
            Console.WriteLine(treeTwo);
        }
    }
}
