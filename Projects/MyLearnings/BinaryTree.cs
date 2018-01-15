/*
Binary Tree Add with:
btree(10)
btree(4)
btree(12)
btree(15)
btree(3)
btree(11)
btree(1)
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsPractice
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

        public int CompareTo(Node current, int value)
        {
            return current.Value.CompareTo(value);
        }
    }

    public class BinaryTree: IEnumerable
    {
        private Node _root;
        private int _count;

        public int Count { get { return _count; } }
        #region Add
        public void Add(int value)
        {
            //if root is null create one based on the value
            if (_root == null)
            {
                _root = new Node(value);
            }
            //Will create a new node somewhere down the chain based on value
            else
            {
                AddTo(_root, value);
            }
            _count++;
        }

        private void AddTo(Node current, int value)
        {
            if (value < current.Value)
            {
                //If there's no left child create it
                if (current.LeftChild == null)
                {
                    current.LeftChild = new Node(value);
                }
                else
                {
                    AddTo(current.LeftChild, value);
                }
            }
            else
            {
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

        #endregion

        #region Search

      
        public bool Contains(int value)
        {
            Node parent;
            return FindWithParent(value, out parent) != null;
        }

        private Node FindWithParent(int value, out Node parent)
        {
            //Try to find data in the tree
            Node current = _root;
            parent = null;

            while (current != null)
            {
                int result = current.Value.CompareTo(value);
                if (result > 0)
                {
                    //if the value is less than the parent, then go left, else go right
                    parent = current;
                    current = current.LeftChild;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.RightChild;
                }
                else
                {
                    //we have a match!!
                    break;
                }
            }
            return current;
        }


        #endregion

        #region Traversals
        public void PreOrderTraversal(Action<int> action)
        {
            PreOrderTraversal(action, _root);
        }

        private void PreOrderTraversal(Action<int> action, Node node)
        {
            if (node != null)
            {
                action(node.Value);
                PreOrderTraversal(action, node.LeftChild);
                PreOrderTraversal(action, node.RightChild);
            }
        }
        public IEnumerator InOrderTraversal()
        {
            // This is a non-recursive algorithm using a stack to demonstrate removing
            // recursion to make using the yield syntax easier.
            if (_root != null)
            {
                // store the nodes we've skipped in this stack (avoids recursion)
                var stack = new Stack<Node>();

                Node current = _root;

                // when removing recursion we need to keep track of whether or not
                // we should be going to the left node or the right nodes next.
                bool goLeftNext = true;

                // start by pushing Head onto the stack
                stack.Push(current);

                while (stack.Count > 0)
                {
                    // If we're heading left...
                    if (goLeftNext)
                    {
                        // push everything but the left-most node to the stack
                        // we'll yield the left-most after this block
                        while (current.LeftChild != null)
                        {
                            stack.Push(current);
                            current = current.LeftChild;
                        }
                    }

                    // in-order is left->yield->right
                    yield return current;

                    // if we can go right then do so
                    if (current.RightChild != null)
                    {
                        current = current.RightChild;

                        // once we've gone right once, we need to start
                        // going left again.
                        goLeftNext = true;
                    }
                    else
                    {
                        // if we can't go right then we need to pop off the parent node
                        // so we can process it and then go to it's right node
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }



        #endregion

        public void Visit(Node current)
        {
            if (current == null)
            {
                return;
            }
            Visit(current.LeftChild);
            ProcessNode(current.Value);
            Visit(current.RightChild);

        }

        private void ProcessNode(int value)
        {
            Console.WriteLine(string.Format("The Node value is {0}", value));
        }

        public Node Find(Node current, int value)
        {
            if (current == null)
            {
                return null;
            }
            
            if (value == current.Value)
            {
                return current;
            } 

            if (value < current.Value)
            {
                return Find(current.LeftChild, value);
            }
            return Find(current.RightChild, value);
        }


        
        public int FindNode(int valueToFind)
        {
            //unsorted array value:  37
            //int[] a = { 23, 12, 56, 34, 9, 2 };
            int[] sortedArray = { 2, 5, 12, 18, 25, 41, 55 };
            int lower = 0;
            int upper = sortedArray.Length-1;
            int mid;

            while (lower <= upper)
            {
                mid = (lower + upper) / 2;
                if (sortedArray[mid] < valueToFind)
                {
                    lower = mid + 1;
                }
                else if (sortedArray[mid] < valueToFind)
                {
                    upper = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1; //error

            ////sort the array
            //BinaryTree binaryTree = new BinaryTree();
            //for (int i = 0; i <= sortedArray.Length-1; i++)
            //{
            //    binaryTree.Add(sortedArray[i]);
            //}

        }

        public IEnumerator GetEnumerator()
        {
            return InOrderTraversal();
        }
    }


}

