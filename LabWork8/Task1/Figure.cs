namespace Task1
{
    internal abstract class Figure
    {
        public abstract double GetSquare();
        public abstract double GetPerimeter();
        public abstract void PrintInfo();

        public abstract string Name { get; }
    }
}
