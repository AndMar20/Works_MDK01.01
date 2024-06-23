using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
           Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}