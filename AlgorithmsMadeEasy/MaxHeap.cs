using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsMadeEasy
{
    class MaxHeap
    {
        private static int capacity = 10;
        private int size = 0;
        int[] items = new int[capacity];

        private int getLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int getRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int getParentIndex(int childIndex) { return (childIndex - 1) / 2; }

        private int getLeftChild(int parentIndex) { return this.items[getLeftChildIndex(parentIndex)]; }
        private int getRightChild(int parentIndex) { return this.items[getRightChildIndex(parentIndex)]; }
        private int getParent(int childIndex) { return this.items[getParentIndex(childIndex)]; }

        private bool hasLeftChild(int parentIndex) { return getLeftChildIndex(parentIndex) < size; }
        private bool hasRightChild(int parentIndex) { return getRightChildIndex(parentIndex) < size; }
        private bool hasParent(int childIndex) { return getLeftChildIndex(childIndex) > 0; }

        private void swap(int indexOne, int indexTwo)
        {
            int temp = this.items[indexOne];
            this.items[indexOne] = this.items[indexTwo];
            this.items[indexTwo] = temp;
        }

        private void hasEnoughCapacity()
        {
            if (this.size == capacity)
            {
                Array.Resize(ref this.items,capacity*2);
                capacity *= 2;
            }
        }

        public void Add(int item)
        {
            this.hasEnoughCapacity();
            this.items[size] = item;
            this.size++;
            heapifyUp();
        }

        public int Pop()
        {
            int item = this.items[0];
            this.items[0] = this.items[size-1];
            this.items[this.size - 1] = 0;
            size--;
            heapifyDown();
            return item;
        }

        private void heapifyUp()
        {
            int index = this.size - 1;
            while (hasParent(index) && this.items[index] > getParent(index))
            {
                swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }

        private void heapifyDown()
        {
            int index = 0;
            while (hasLeftChild(index))
            {
                int bigChildIndex = getLeftChildIndex(index);
                if (hasRightChild(index) && getLeftChild(index) < getRightChild(index))
                {
                    bigChildIndex = getRightChildIndex(index);
                }

                if (this.items[bigChildIndex] < this.items[index])
                {
                    break;
                }
                else
                {
                    swap(bigChildIndex,index);
                    index = bigChildIndex;
                }
            }

            
        }
    }
}
