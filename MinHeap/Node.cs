using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    class Node
    {
        private int value;
        private Node leftChild;
        private Node rightChild;
        private Node parent;

        public Node(int value, Node parent = null)
        {
            this.value = value;
        }

        public int getValue()
        {
            return this.value;
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public Node getLeftChild()
        {
            return this.leftChild;
        }

        public void setLeftChild(Node child)
        {
            this.leftChild = child;
        }

        public Node getRightChild()
        {
            return this.rightChild;
        }

        public void setRightChild(Node child)
        {
            this.rightChild = child;
        }

        public Node getParent()
        {
            return this.parent;
        }

        public void setParent(Node parent)
        {
            this.parent = parent;
        }
    }
}
