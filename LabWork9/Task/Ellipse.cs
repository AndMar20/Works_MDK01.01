namespace Task
{
    internal class Ellipse : IFigure, IPrinter
    {

        public string _name;
        public double _radius;

        #region Конструкторы
        public Ellipse() : this("Фигура", 0) { }

        public Ellipse(string name, double radius)
        {
            Name = name;
            Radius = radius;

        }
        #endregion

        #region Методы
        public void GetSquare()
        {
            Console.WriteLine($"Площадь: {Math.Round(3.14 * Radius * Radius, 2)}");
        }

        public void GetPerimetr()
        {
            Console.WriteLine($"Периметр: {Math.Round(2 * 3.14 * Radius, 2)}");
        }

        public void GetFigureInfo()
        {
            Console.WriteLine($"Название фигуры: {Name} \nРадиус: {Radius}");
        }

        public void Print()
        {
            Console.WriteLine($"Название фигуры: {Name} \nРадиус: {Radius}");
            GetSquare();
            GetPerimetr();
        }
        #endregion

        #region Свойства
        public string Name { get; set; }
        public double Radius { get; set; }
        #endregion


    }
}
