using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewUnit4;
namespace ConsoleApp16
{
    public class Program
    {
        public static void Main()
        {
            Stack<int> st2 = new Stack<int>();
            st2.Push(0);
            st2.Push(-8);
            st2.Push(-11);
            st2.Push(-7);
            st2.Push(-6);
            st2.Push(-1);
            st2.Push(-3);
            st2.Push(0);
            Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(7);
            st1.Push(2);
            st1.Push(4);
            st1.Push(9);
            st1.Push(3);
            st1.Push(1);
            Console.WriteLine(KmoShneyEvarim(st1,st2));
            Console.ReadLine();
        }
        public static int BiggestSumofst2(Stack<int>st)
        {
            int biggestsum = st.Top();
            int temp = st.Pop();
            biggestsum += st.Top();
            while (!st.IsEmpty())
            {
                if (biggestsum < (temp + st.Top()))
                    {
                        biggestsum = temp + st.Top();
                    }
                temp = st.Pop();
            }
            return biggestsum;

        }
        public static int KmoShneyEvarim(Stack<int>st1 , Stack<int>st2)
        {
            int temp1 = st1.Pop();
            while (!st1.IsEmpty())
            {
                if((temp1+st1.Top())> BiggestSumofst2(st2))
                {
                    return temp1 + st1.Top();
                }
                temp1 = st1.Pop();
            }
            return 0;

        }
    }
}
