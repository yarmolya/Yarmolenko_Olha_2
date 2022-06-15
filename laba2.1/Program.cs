using System;
using System.Text;
namespace laba2.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; string a; int b;
            Console.WriteLine("Кiлькiсть гiлок: ");
            b = int.Parse(Console.ReadLine());
            Tree tree = new Tree(b);
            Console.WriteLine("Створимо дерево: ");
            tree.Info();
            Console.WriteLine("Бажаєте, щоб дерево зацвіло? [y/n]"); a = Console.ReadLine();
            if (a == "y")
            {
                tree.Blossom();
                tree.Info();
            }
            Console.WriteLine("Бажаєте, щоб листя пожовкло? [y/n]"); a = Console.ReadLine();
            if (a == "y")
            {
                tree.Yellow();
                tree.Info();
            }
            Console.WriteLine("Бажаєте, щоб листя опало? [y/n]"); a = Console.ReadLine();
            if (a == "y")
            {
                tree.Fade();
                tree.Info();
            }
            Console.WriteLine("Бажаєте, щоб дерево вкрилося інієм? [y/n]"); a = Console.ReadLine();
            if (a == "y")
            {
                tree.Frozen();
                tree.Info();
            }
            Console.WriteLine(" ");
            Console.WriteLine("Ваше фінальне дерево: ");
            tree.Info();
        }
    }
}