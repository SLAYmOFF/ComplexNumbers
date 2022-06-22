namespace ComplexNumbers
{
    public class ComplexNumber
    {
        double x;
        double y;
        double X
        {
            get { return x; }
            set { x = value; }
        }
        double Y
        {
            get { return y; }
            set 
            { 
                if (value != 0) 
                    y = value; 
            }
        }

        public ComplexNumber(double x, double y)
        {
            X = x;
            Y = y;
        }

        public string View()
        {
            if (y >= 0)
                return ($"{x}+{y}i");
            else
                return ($"{x}{y}i");
        }

        public static string ComplexNumbersAddition(ComplexNumber number1, ComplexNumber number2)
        {
            var tempComplexNumber = new ComplexNumber(number1.X + number2.X, number1.Y + number2.Y);
            return tempComplexNumber.View();
        }

        public static string ComplexNumbersMultiply(ComplexNumber number1, ComplexNumber number2)
        {
            var tempComplexNumber = new ComplexNumber(number1.X * number2.X - number1.Y * number2.Y, number1.X * number2.Y + number1.Y * number2.X);
            return tempComplexNumber.View();
        }
    }
}
