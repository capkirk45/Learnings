using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; }
        public int  CompareTo(Node current, int value)
        {
            return current.Value.CompareTo(value);
        }
    }

    public interface IBTree
    {
        void Add(int value);
        void AddTo(Node current, int value);
    }

    public class BinaryTree: IBTree
    {
        private Node _root;
        private int _count;

        public void Add(int value)
        {
            //If root is null, set it to current
            if (_root == null)
            {
                _root = new Node(value);
            }
            else
            {
                AddTo(_root, value);
            }
            _count++;
        }

        public void AddTo(Node current, int value)
        {
            //Case1:  if value is less current root
            if (value < _root.Value)
            {
                //If there's no left child, set to current
                if (current.LeftChild == null)
                {
                    current.LeftChild = new Node(value);
                }
                //Otherwise recurse back using left child
                else
                {
                    AddTo(current.LeftChild, value);
                }
            }
            //Case2:  value is greater than current root
            else
            {
                //if there's no right child, set to current
                if (current.RightChild == null)
                {
                    current.RightChild = new Node(value);
                }
                else
                {
                    AddTo(current.RightChild, value);
                }
            }
        }
    }

}

