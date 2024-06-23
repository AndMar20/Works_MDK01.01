using System.Xml.Linq;
using System;

namespace Task5
{
    internal class StringComparer : IComparer<Pet>
    {
        public int Compare(Pet? pet1, Pet? pet2)
        {
            return pet1.Name.Length - pet2.Name.Length;
        }
    }
}
