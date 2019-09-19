using System;
using System.Collections.Generic;

namespace matala3
{
    public class PriorityQueue
    {
        public List<Preposal> list;
        public int Count { get; set; }

        public PriorityQueue(int count)
        {
            Count = count;
            list = new List<Preposal>(count);
        }


        public void Enqueue(Preposal preposal)
        {
            list.Add(preposal);
            int i = Count - 1;

            while (i > 0)
            {
                int p = (i - 1) / 2;
                if (list[p].PreposalAmount <= preposal.PreposalAmount)
                    break;

                list[i] = list[p];
                i = p;
            }

            if (Count > 0) list[i] = preposal;
        }

        public Preposal Dequeue()
        {
            Preposal min = Peek();
            Preposal root = list[Count - 1];
            list.RemoveAt(Count - 1);

            int i = 0;
            while (i * 2 + 1 < Count)
            {
                int a = i * 2 + 1;
                int b = i * 2 + 2;
                int c = b < Count && list[b].PreposalAmount < list[a].PreposalAmount ? b : a;

                if (list[c].PreposalAmount >= root.PreposalAmount) break;
                list[i] = list[c];
                i = c;
            }

            if (Count > 0) list[i] = root;
            return min;
        }

        public Preposal Peek()
        {
            if (Count == 0) throw new InvalidOperationException("Queue is empty.");
            return list[0];
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
