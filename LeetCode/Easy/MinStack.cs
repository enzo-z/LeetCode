using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MinStack
    {
        public class MyMinStack
        {
            private List<int> listStack;

            public MyMinStack()
            {
                listStack = new();
            }

            public void Push(int val) => listStack.Add(val);

            public void Pop() => listStack.RemoveAt(listStack.Count - 1);

            public int? Top() => listStack.ElementAtOrDefault( listStack.Count - 1 );

            public int GetMin() => listStack.Min();
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(val);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */

    }
}
