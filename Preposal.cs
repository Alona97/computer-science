using System;
namespace matala3
{
    public class Preposal
    {
        public string PreposalName { get; set; }
        public int PreposalAmount { get; set; }

        public Preposal(string name, int amount)
        {
            PreposalAmount = amount;
            PreposalName = name;
        }
    }
}
