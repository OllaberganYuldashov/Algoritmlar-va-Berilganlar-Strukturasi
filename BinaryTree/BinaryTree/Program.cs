using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node()
        {

        }
        public Node(int value)
        {
            this.Value = value;

        }
    }
    public class BinaryTree
    {
        private Node main_root;
        
        public BinaryTree()
        {
            main_root = null;
        }
        
        public void Insert(int value)
        {
            
            if (main_root == null)
            {
                main_root = new Node(value);
                return;
            }
             
            InsertNode(main_root, new Node(value));
        }
        
        private void InsertNode(Node root, Node newNode)
        {
            if (root == null)
                root = newNode;

            if (newNode.Value < root.Value)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertNode(root.Left, newNode);

            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertNode(root.Right, newNode);
            }
        }
        private void DisplayTree(Node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            System.Console.Write(root.Value + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(main_root);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.DisplayTree();
            Console.ReadKey();
        }
    }
}
