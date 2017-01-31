using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class LowestCommonAncestorBinaryTree
    {
        public void Main()
        {
            BtTree tree = new BtTree();
            tree.Add(5,null);
            tree.Add(3,null);
            tree.Add(4,null);
            tree.Add(6,null);
            tree.Add(11,null);
            tree.Add(13,null);
            tree.Add(9,null);
            tree.Add(2,null);

            Node lcaObj = lca(tree.root, 2, 6);
            Console.WriteLine(lcaObj.value);
            Console.ReadLine();
        }

        public Node lca(Node root, int child1, int child2)
        {
            if (root == null) return null;
            if (root.value == child1 || root.value == child2) return root;

            Node left = lca(root.leftElement, child1, child2);
            Node right = lca(root.rightElement, child1, child2);

            if (left != null && right != null) return root;

            if (left == null && right == null) return null;

            return right ?? left;
        }
    }

    class BtTree
    {
        public Node root = null;

        public void Add(int value, Node currentNode)
        {
            if (root == null)
            {
                Node n = new Node();
                n.value = value;
                this.root = n;
            }
            else
            {
                if (currentNode == null)
                {
                    currentNode = this.root;
                }

                if (currentNode.value >= value)
                {
                    //Move Left
                    if (currentNode.leftElement == null)
                    {
                        currentNode.leftElement = new Node { value = value, leftElement = null, rightElement = null };
                    }
                    else
                    {
                        Add(value, currentNode.leftElement);
                    }

                }
                else
                {
                    //Move Right
                    if (currentNode.rightElement == null)
                    {
                        currentNode.rightElement = new Node { value = value, leftElement = null, rightElement = null };
                    }
                    else
                    {
                        Add(value, currentNode.rightElement);
                    }

                }
            }
        }
    }
}
