using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    class Tree
    {
        private Node root;
        private int level = 0;

        public Tree()
        {
            root = null;
        }   

        public Tree(Node initRoot)
        {
            root = initRoot;
            this.level = 1;
        }

        public void insert(int value)
        {
            //Insert the element at bottom rightmost spot
            Node newNode = insertBottomRightmost(this.root, value);

            //Swap new element with parents until parent is smaller element is root
        }

        public void printTree()
        {
            printTree(this.root);
        }

        public void printTree(Node currNode, int spacing = 0)
        {
            if(currNode.getRightChild() != null)
            {
                printTree(currNode.getRightChild(), spacing + 1);
            }

            Console.WriteLine(new String('\t', spacing) + currNode.getValue().ToString());

            if(currNode.getLeftChild() != null)
            {
                printTree(currNode.getLeftChild(), spacing + 1);
            }
        }

        // Consider removing. May be redundant
        private Node createNode(int value, Node parent = null)
        {
            return new Node(value, parent);
        }

        private Node insertBottomRightmost(Node currNode, int value, int currLevel = 1)
        { 
            if(this.root == null)
            {
                this.root = createNode(value);
                this.level = 1;
                return this.root;
            }



            if (currNode.getLeftChild() == null)
            {
                Node newNode = createNode(value);
                currNode.setLeftChild(newNode);
                newNode.setParent(currNode);

                //Increase level if far-left
                if(currLevel <= this.level)
                {
                    this.level++;
                }
                return newNode;
            }

            if (currNode.getRightChild() == null)
            {
                Node newNode = createNode(value);
                currNode.setRightChild(newNode);
                newNode.setParent(currNode);
                return newNode;
            }

            //Check two levels under
            if(currNode.getLeftChild().getLeftChild() == null || currNode.getLeftChild().getRightChild() == null)
            {
                return insertBottomRightmost(currNode.getLeftChild(), value);
            }

            if (currNode.getLeftChild() != null && currNode.getRightChild() != null)
            {
                return insertBottomRightmost(currNode.getLeftChild(), value);
            }

            if (currNode.getRightChild() != null)
            {
                return insertBottomRightmost(currNode.getRightChild(), value);
            }

            throw new Exception("Not able to traverse tree.");
        }


    }
}
