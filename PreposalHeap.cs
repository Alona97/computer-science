using System;

namespace matala3
{
    internal class PreposalHeap
    {
        private Preposal[] preposals;
        private int size;
       // private int currentIndex = 0;
        private PriorityQueue priorityQueue;

        public PreposalHeap(Preposal[] preposals, int size)
        {
            this.preposals = preposals;
            this.size = size;
            this.priorityQueue = new PriorityQueue(size);
            BuildMaxHeap();
        }

        private void BuildMaxHeap()
        {
            for (int i = this.size / 2; i > 0; i--)
            {
                MaxHeapify(i);
                this.priorityQueue.Enqueue(preposals[i]);
            }
        }

        private void MaxHeapify(int index)
        {
            var left = 2 * index;
            var right = 2 * index + 1;

            int max = index;
            if (left <= this.size && this.preposals[left - 1].PreposalAmount > this.preposals[index - 1].PreposalAmount)
            {
                max = left;
            }

            if (right <= this.size && this.preposals[right - 1].PreposalAmount > this.preposals[max - 1].PreposalAmount)
            {
                max = right;
            }


            if (max != index)
            {
                Preposal temp = this.preposals[max - 1];
                this.preposals[max - 1] = this.preposals[index - 1];
                this.preposals[index - 1] = temp;
                MaxHeapify(max);
            }
        }

        public Preposal RemoveMaximum()
        {
            return this.preposals[0];
        }
        public void printHeap()
        {
            for (int i = 0; i < this.priorityQueue.Count; i++)
            {
                Console.WriteLine(this.priorityQueue.list[i].PreposalAmount);
            }
        }
    }
    }