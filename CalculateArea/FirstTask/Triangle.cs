namespace FirstTask
{
    public class Triangle : IArea
    {
        public double FirstLine { get; init; }
        public double SecondLine { get; init; }
        public double ThirdLine { get; init; }
        public bool IsRightTriangle { get; init; }

        public Triangle(double firstLine, double secondLine, double thirdLine)
        {
            if (firstLine < 0 || secondLine < 0 || thirdLine < 0)
                throw new ArgumentException("Triangle lines can not be less than zero");

            if (!IsValid(firstLine, secondLine, thirdLine))
                throw new ArgumentException("Triangle with such sides cannot exist");

            this.FirstLine = firstLine;
            this.SecondLine = secondLine;
            this.ThirdLine = thirdLine;
            this.IsRightTriangle = CheckIsRightTriangle();
        }

        public double TryFindArea()
        {
            var semiPerimeter = (FirstLine + SecondLine + ThirdLine) / 2;
            var square = Math.Sqrt(semiPerimeter 
                            * (semiPerimeter - FirstLine) 
                            * (semiPerimeter - SecondLine) 
                            * (semiPerimeter - ThirdLine));
            return Math.Round(square, 7);
        }

        private bool IsValid(double firstLine, double secondLine, double thirdLine)
        {
            bool isFirstLess = firstLine < secondLine + thirdLine;
            bool isSecondLess = secondLine < firstLine + thirdLine;
            bool isThirdLess = thirdLine < firstLine + secondLine;

            return isFirstLess && isSecondLess && isThirdLess;
        }

        private bool CheckIsRightTriangle()
        {
            var lines = new List<double>() { FirstLine, SecondLine, ThirdLine };
            var hypotenuse = lines.Max();
            lines.Remove(hypotenuse);

            var squareHypotenuse = hypotenuse * hypotenuse;
            var sumSquaresLegs = lines[0] * lines[0] + lines[1] * lines[1];
            var epsilon = 0.06;
            var isRightTriangle = Math.Abs(squareHypotenuse - sumSquaresLegs) < epsilon;

            return isRightTriangle;
        }
    }
}