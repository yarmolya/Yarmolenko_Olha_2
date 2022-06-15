using System;
namespace laba2.Properties
{
    internal class Branches : Leaves
    {
        public int LeafCount { get; set; }
        public Leaves[] leaves;
        public Branches(int leafCount)
        {
            if (leafCount < 0)
            {
                LeafCount = 0;
            }
            else
            {
                LeafCount = leafCount;
            }
            leaves = new Leaves[leafCount];

            for (int i = 0; i < leafCount; i++)
            {
                leaves[i] = new Leaves();
            }
        }
        protected string flower; protected Branches()
        {
            flower = "немає";
        }
        public string Flower
        {
            get => flower;
            set => flower = value;
        }
    }
}