namespace LabWorkLibrary
{
    /// <summary>
    /// Содержит в себе математические методы и константу.
    /// </summary>
    public class Maths
    {
        /// <summary>
        /// 2^10
        /// </summary>
        public const int BINARY_FACTORY = 1024;

        /// <summary>Вычисляет сумму двух чисел</summary>      
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое</param>
        /// <returns> Возвращает сумму двух чисел</returns>       
        public static double GetSumm(double a, double b) => a + b;

        /// <summary>Вычисляет разность двух чисел</summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Возвращает разность двух чисел</returns>
        public static double GetDifference(double a, double b) => a - b;

        /// <summary>Вычисляет произведение двух чисел</summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns>Возвращает произведение двух чисел</returns>
        public static double GetMultiply(double a, double b) => a * b;

        /// <summary>Вычисляет частное двух чисел</summary>
        /// <param name="a">Делимое</param>
        /// <param name="b">Делитель</param>
        /// <returns>Возвращает частное двух чисел</returns>
        /// <exception cref="DivideByZeroException">
        /// Неправильно введено значение делителя."
        /// </exception>
        public static double GetDivide(double a, double b)
        {
            if (b == 0)          
                throw new DivideByZeroException("Некорректно введенные данные. Делить на 0 нельзя.");
            return a / b;
        }

        /// <summary> Вычисляет площадь прямоугольника</summary>
        /// <param name="height">Длина</param>
        /// <param name="width">Ширина</param>
        /// <returns>Возвращает площадь прямоугольника</returns>
        /// <exception cref="System.ArgumentException">
        /// Неправильно введены значения сторон прямоугольника."
        /// </exception>
        public static double GetRectangleSquare(double height, double width)
        {
            if (height <= 0 || width <= 0)
                throw new ArgumentException("Неккоректно введенные данные. Стороны не могут быть отрицательными или равны 0");
            return height * width;
        }

        /// <summary>Вычисляет модуль числа</summary>
        /// <param name="a">Число из которого надо вычислить модуль</param>
        /// <returns>Возвращает модуль числа</returns>
        public static double GetAbs(double a) 
        {
            if (a < 0)
                return -a;
            return a;
        }

    }
}