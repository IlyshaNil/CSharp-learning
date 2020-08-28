namespace CSharp_learning
{
    public class AdHocPoly
    {
        public int GetMax(int first, int second)
        {
            return first < second ? second : first;
        }

        public string GetMax(string first, string second)
        {
            return first.Length > second.Length ? first : second;
        }

        public int GetMaxParam(params int[] args)
        {
            int result = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > result)
                {
                    result = args[i];
                }
            }

            return result;
        }
    }
}