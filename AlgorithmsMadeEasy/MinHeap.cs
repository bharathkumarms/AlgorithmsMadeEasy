using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    public class MinHeap
    {
        private static int capacity = 10;
        private int size = 0;

        int[] items = new int[capacity];

        private int getLeftChildIndex(int parentIndex) { return 2*parentIndex+1 ; }
        private int getRightChildIndex(int parentIndex) { return 2*parentIndex+2 ; }
        private int getParentIndex(int childIndex) { return (childIndex - 1) / 2; }

        private bool hasLeftChild(int index) { return getLeftChildIndex(index) < size; }
        private bool hasRightChild(int index) { return getRightChildIndex(index) < this.size; }
        private bool hasParent(int index) { return getParentIndex(index) >= 0; }

        private int leftChild(int index) { return this.items[getLeftChildIndex(index)]; }
        private int rightChild(int index) { return this.items[getRightChildIndex(index)]; }
        private int parent(int index) { return this.items[this.getParentIndex(index)]; }

        private void swap(int indexOne, int indexTwo)
        {
            int temp = this.items[indexOne];
            this.items[indexOne] = this.items[indexTwo];
            this.items[indexTwo] = temp;
        }

        private void ensureExtraCapacity()
        {
            if (this.size == capacity)
            {
                Array.Resize(ref this.items, capacity*2);
                capacity *= 2;
            }
        }

        public int peek()
        {
            if(this.size==0) throw new NotSupportedException();
            return this.items[0];
        }

        public int remove()
        {
            if(this.size==0) throw new NotSupportedException();
            int item = this.items[0];
            items[0] = items[this.size - 1];
            items[this.size - 1] = 0;
            this.size--;
            heapifyDown();
            return item;
        }

        public void Add(int item)
        {
            this.ensureExtraCapacity();
            this.items[size] = item;
            this.size++;
            heapifyUp();
        }

        private void heapifyUp()
        {
            int index = this.size - 1;
            while (hasParent(index) && parent(index) > this.items[index])
            {
                swap(index,getParentIndex(index));
                index = getParentIndex(index);
            }
        }

        private void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && rightChild(index) < leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (this.items[index] < this.items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    swap(index,smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }
    }
}

/*
Calling Code:
    MinHeap mh = new MinHeap();
    mh.Add(10);
    mh.Add(5);
    mh.Add(2);
    mh.Add(1);
    mh.Add(50);
    int peek = mh.peek();
    mh.remove();
    int newPeek = mh.peek();
*/
