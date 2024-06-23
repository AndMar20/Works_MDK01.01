namespace Task1
{
    internal class Rectangle : Figure
    {
        public string _name;
        public double _height;
        public double _width;

        #region Конструкторы
        public Rectangle() : this(1, 1) { }


        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        #endregion

        #region Методы
        public override double GetSquare() => Height * Width;

        public override double GetPerimeter() => (Height + Width) * 2;

        public override void PrintInfo()
        {
            Console.WriteLine($"Название фигуры: {Name} \nПлощадь: {GetSquare()} \nПериметр: {GetPerimeter()}");
        }
        #endregion

        #region Свойства
        public override string Name { get => "Прямоугольник"; }
        public double Height { get; set; }
        public double Width { get; set; }
        #endregion

    }
}


