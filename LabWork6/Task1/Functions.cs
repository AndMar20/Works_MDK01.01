namespace Task1
{
    public class Functions
    {
        public static double GetSquare(double width) => width * width;

        public static double GetSquare(double width, double height) => width * height;

        public static double GetRational(double number, double power)
        {
            if (power > 0)
            {
                double result = number;
                for (int i = 1; i < power; i++)
                {
                    result *= number;
                }
                return 1 / result;
            }
            return -1;
        }

        public static double GetRational(double x)
        {
            return 1 / x;
        }
    }
}
