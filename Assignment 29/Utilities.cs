
using System.Text;

namespace Assignment29{
    public static class Utilities
    {
        static public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static public string RepeatString(this string s, int n)
        {
            StringBuilder sb = new();
            for (int i = 0; i < n; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}

