namespace Task1
{
    internal class ExtendedRandom : Random
    {
        public string GetRandomScaredText(int length)
        {
            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += (char)Next('A', 'Z' + 1);
            }
            return result;
        }
    }
}
