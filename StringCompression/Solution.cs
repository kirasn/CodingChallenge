namespace StringCompression
{
    public class Solution
    {
        public string StringOutput(string s)
        {
            string output = "";
            var count = 0;
            var previousChar = s.Substring(0, 1);

            while (s.Length > 0)
            {
                previousChar = s.Substring(0, 1);
                count++;
                s = s.Remove(0, 1);

                foreach (var item in s)
                {
                    if (item.ToString() == previousChar)
                    {
                        s = s.Remove(0, 1);
                        count++;
                    }
                    else
                    {
                        output += $"{previousChar}{count}";
                        previousChar = s.Substring(0, 1);
                        count = 0;

                        break;
                    }
                }

                if (s.Length == 0)
                {
                    output += $"{previousChar}{count}";
                }
            }

            return output;
        }
    }
}