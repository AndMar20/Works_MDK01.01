namespace Task5
{
    internal class DescendingComparer : IComparer<Pet>
    {
        public int Compare(Pet? x, Pet? y)
        {
            if (x.Age < y.Age)
                return 1;
            if (x.Age > y.Age)
                return -1;
            else return 0;
        }
    }
}
