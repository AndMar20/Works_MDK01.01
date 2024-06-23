using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class ShapeFactory
    {
        public IShape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Circle();
            }
            if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }
            if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            if (shapeType.Equals("TRIANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Triangle();
            }
            return null;
        }
    }
}