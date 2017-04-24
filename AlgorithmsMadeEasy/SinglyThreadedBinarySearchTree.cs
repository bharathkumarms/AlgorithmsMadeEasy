using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;
using QuickGraph;

namespace AlgorithmsMadeEasy
{
    class SinglyThreadedBinarySearchTree
    {
        public static Node1 root;

        public void SinglyThreadedBinarySearchTreeMethod()
        {
            root = new Node1(100);
            SinglyThreadedBinarySearchTree st = new SinglyThreadedBinarySearchTree();
            st.insert(root, 50);
            st.insert(root, 25);
            st.insert(root, 7);
            st.insert(root, 20);
            st.insert(root, 75);
            st.insert(root, 99);

            st.print(root);
        }

        public void insert(Node1 root, int id)
        {
            Node1 newNode = new Node1(id);
            Node1 current = root;
            Node1 parent = null;
            while (true)
            {
                parent = current;
                if (id < current.data)
                {
                    current = current.left;
                    if (current == null)
                    {
                        parent.left = newNode;
                        newNode.right = parent;
                        newNode.rightThread = true;
                        return;
                    }
                }
                else
                {
                    if (current.rightThread == false)
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                    else
                    {
                        Node1 temp = current.right;
                        current.right = newNode;
                        newNode.right = temp;
                        newNode.rightThread = true;
                        return;
                    }
                }
            }
        }

        public void print(Node1 root)
        {
            Node1 current = leftMostNode(root);

            while (current != null)
            {
                Console.Write(" " + current.data);
                if (current.rightThread)
                    current = current.right;
                else
                    current = leftMostNode(current.right);
            }
            Console.WriteLine();
        }

        public Node1 leftMostNode(Node1 Node1)
        {
            if (Node1 == null)
            {
                return null;
            }
            else
            {
                while (Node1.left != null)
                {
                    Node1 = Node1.left;
                }
                return Node1;
            }
        }
    }

    public class Node1
    {
        public Node1 left;
        public Node1 right;
        public int data;
        public bool rightThread;
        public Node1(int data)
        {
            this.data = data;
            rightThread = false;
        }
    }
}