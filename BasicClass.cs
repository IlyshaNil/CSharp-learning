using System;

namespace CSharp_learning
{
    public class BasicClass
    {
        public int FindMax(int first, int second)
        {
            int result;

            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }
    }
}