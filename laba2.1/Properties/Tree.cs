using System;
namespace laba2.Properties
{
    internal class Tree : Branches
    {
        private int branchCount;
        private int leafCount;
        public Branches[] branches;

        public Tree(int branchCount)
        {
            if (branchCount <= 0)
            {
                this.branchCount = 1;
            }
            else
            {
                this.branchCount = branchCount;
            }
            branches = new Branches[branchCount];

            Console.WriteLine("Кiлькiсть листочків на гiлцi: ");
            leafCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < branchCount; i++)
            {
                branches[i] = new Branches(leafCount);
            }
        }
        public string Fade()
        {
            Console.WriteLine("Листя опало!"); color = "-"; leafCount = 0;
            return color;
        }
        public string Frozen()
        {
            Console.WriteLine("Дерево вкрилося інієм!"); color = "-"; leafCount = 0;
            flower = "немає";
            return color;
            return flower;
        }
        public string Blossom()
        {
            Console.WriteLine("Дерево зацвіло!"); flower = "є";
            return flower;
        }
        public string Yellow()
        {
            Console.WriteLine("Листя пожовкло!"); color = "жовтий"; flower = "немає";
            return color;
        }
        public void Info()
        {
            Console.WriteLine("Колір листя: {0}, суцвіття: {1}, кількість гілок: {2}, кількість листочків на гілці: {3}.", color, flower, branchCount, leafCount);
        }
    }
}
