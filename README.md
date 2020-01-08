using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewUnit4;
namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            BinNode<int> li = new BinNode<int>(1);
            BinNode<int> pos2 = li;
            pos2.SetRight(new BinNode<int>(5));
            pos2 = pos2.GetRight();
            pos2.SetRight(new BinNode<int>(3));
            pos2 = pos2.GetRight();
            pos2.SetRight(new BinNode<int>(9));
            pos2 = pos2.GetRight();
            pos2.SetRight(new BinNode<int>(20));
            pos2 = pos2.GetRight();
            pos2.SetRight(new BinNode<int>(15));
            Node<BinNode<int>>li3 = re(li);

            Console.WriteLine(li3);
        }
        public static Node<BinNode<int>> re(BinNode<int> li)
        {
            BinNode<int> pos = li;
            Node<BinNode<int>> li2 = new Node<BinNode<int>>(null);
            if (pos.HasRight())
            {
                if (pos.GetValue() > pos.GetRight().GetValue())
                { li2 = new Node<BinNode<int>>(pos, li2); }

            }
            while (pos.HasRight())
            {
                pos = pos.GetRight();
                if (pos.HasRight())
                {
                    if (pos.GetValue() > pos.GetLeft().GetValue() && pos.GetValue() > pos.GetRight().GetValue())
                    {
                        li2 = new Node<BinNode<int>>(pos, li2);

                    }
                }
                else
                {
                    if (pos.GetValue() > pos.GetLeft().GetValue())
                        li2 = new Node<BinNode<int>>(pos, li2);
                }

            }
            return li2;
        }
    }
        
}
