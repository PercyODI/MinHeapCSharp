using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    class Tree
    {
        private List<Node> treeArray = new List<Node>();

        public Tree()
        {
            treeArray.Insert(0, null);
        }

        public void insert(int value)
        {
            //Insert the element at bottom rightmost spot
            int newNodeIndex = treeArray.Count;
            Node newNode = new Node(value);
            treeArray.Add(newNode);

            //Swap new element with parents until parent is smaller element is root
            while (newNodeIndex > 1 && treeArray[newNodeIndex].getValue() < treeArray[newNodeIndex/2].getValue())
            {
                Node holdNode = treeArray[newNodeIndex/2];
                treeArray[newNodeIndex/2] = newNode;
                treeArray[newNodeIndex] = holdNode;

                newNodeIndex = newNodeIndex/2;
            }
        }

        public Node extractMin()
        {
            Node minNode = treeArray[1];

            treeArray[1] = treeArray[treeArray.Count - 1];
            treeArray.RemoveAt(treeArray.Count - 1);
            swapDown(1);

            return minNode;
        }

        public void swapDown(int indexTop)
        {
            Node holdNode;
            if ((2*indexTop) < treeArray.Count && treeArray[indexTop].getValue() > treeArray[2*indexTop].getValue())
            {
                holdNode = treeArray[indexTop];
                treeArray[indexTop] = treeArray[2*indexTop];
                treeArray[2*indexTop] = holdNode;
                swapDown(2*indexTop);
                return;
            }
            else if (((2 * indexTop) + 1) < treeArray.Count && treeArray[indexTop].getValue() > treeArray[(2*indexTop) + 1].getValue())
            {
                holdNode = treeArray[indexTop];
                treeArray[indexTop] = treeArray[(2 * indexTop) + 1];
                treeArray[(2 * indexTop) + 1] = holdNode;
                swapDown((2 * indexTop) + 1);
                return;
            }

            return;
        }

        public void printTree()
        {
            int numlayers = (int)Math.Ceiling(Math.Log(treeArray.Count)/Math.Log(2));
            int currentNumTabs = (int)Math.Pow(numlayers, 2);
            int currentLinePos = 1;
            int nextNewline = 1;
            for(int i = 1; i < treeArray.Count; i++)
            {
                Console.Write(new String(' ', Math.Max(0, currentNumTabs)) + treeArray[i].getValue());
                currentLinePos++;
                if (currentLinePos > nextNewline)
                {
                    Console.Write("\n");
                    currentNumTabs /= 2;
                    nextNewline *= 2;
                    currentLinePos = 1;
                }
            }
            Console.Write("\n");
        }

        // Consider removing. May be redundant
        //private Node createNode(int value, Node parent = null)
        //{
        //    return new Node(value);
        //}

        //private Node insertBottomRightmost(Node currNode, int value, int currLevel = 1)
        //{ 
        //    if(this.root == null)
        //    {
        //        this.root = createNode(value);
        //        this.level = 1;
        //        return this.root;
        //    }
            
        //    if (currNode.getLeftChild() == null)
        //    {
        //        Node newNode = createNode(value);
        //        currNode.setLeftChild(newNode);
        //        newNode.setParent(currNode);

        //        //Increase level if far-left
        //        if(currLevel <= this.level)
        //        {
        //            this.level++;
        //        }
        //        return newNode;
        //    }

        //    if (currNode.getRightChild() == null)
        //    {
        //        Node newNode = createNode(value);
        //        currNode.setRightChild(newNode);
        //        newNode.setParent(currNode);
        //        return newNode;
        //    }

        //    if (currNode.getLeftChild() != null && currNode.getRightChild() != null)
        //    {
        //        return insertBottomRightmost(currNode.getLeftChild(), value);
        //    }

        //    if (currNode.getRightChild() != null)
        //    {
        //        return insertBottomRightmost(currNode.getRightChild(), value);
        //    }

        //    throw new Exception("Not able to traverse tree.");
        //}


    }
}
