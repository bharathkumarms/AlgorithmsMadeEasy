using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class BinarySearchTree
    {
        public void BinarySearchTreeMethod()
        {
            Tree tree = new Tree();
            tree.Add(3, null);
            tree.Add(5, null);
            tree.Add(2, null);
            tree.Add(1, null);
            tree.Add(4, null);
            tree.Add(6, null);
            tree.Add(7, null);
            int depth = tree.Depth(tree.root);

            tree.Inorder(tree.root);
            System.Console.WriteLine();
            tree.Preorder(tree.root);
            System.Console.WriteLine();
            tree.Postorder(tree.root);
            System.Console.WriteLine();
            Console.ReadLine();   
        }
    }

    class Node
    {
        public int value { get; set; }

        public Node leftElement { get; set; }

        public Node rightElement { get; set; }
    }

    class Tree
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
                        Add(value,currentNode.leftElement);
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

        public int Depth(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            int leftDepth = Depth(root.leftElement) +1;
            int rightDepth = Depth(root.rightElement)+1;

            return Max(rightDepth,leftDepth);
        }

        public int Max(int a, int b)
        {
            if (a > b) return a;

            return b;
        }

        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.leftElement);
                Console.Write(root.value + " ");
                Inorder(root.rightElement);
            }
        }

        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.value + " ");
                Preorder(root.leftElement);
                Preorder(root.rightElement);
            }
        }

        public void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.leftElement);
                Postorder(root.rightElement);
                Console.Write(root.value + " ");
            }
        }
    }
}
