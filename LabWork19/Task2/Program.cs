using Task2;

ShapeFactory shapeFactory = new ShapeFactory();

IShape shape1 = shapeFactory.GetShape("CIRCLE");
shape1.Draw();

shape1 = shapeFactory.GetShape("RECTANGLE");
shape1.Draw();

shape1 = shapeFactory.GetShape("SQUARE");
shape1.Draw();

shape1 = shapeFactory.GetShape("TRIANGLE");
shape1.Draw();