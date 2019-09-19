using System;

namespace matala3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = "";
            int amount = 0;

            Console.WriteLine("Enter number of preposals: ");
            int size = int.Parse(Console.ReadLine());

            Preposal[] preposals = new Preposal[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter amount: ");
                amount = int.Parse(Console.ReadLine());
                preposals[i] = new Preposal(name, amount);
            }

            PreposalHeap heap = new PreposalHeap(preposals, size);
            heap.printHeap();

        }
    }
}
