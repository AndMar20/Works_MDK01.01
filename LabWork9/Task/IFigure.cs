namespace Task
{
    internal interface IFigure
    {
        public void GetSquare();
        public void GetPerimetr();
        public void GetFigureInfo();

        public string Name { get; set; }
    }
}
