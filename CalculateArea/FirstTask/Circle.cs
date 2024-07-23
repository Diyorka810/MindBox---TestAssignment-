namespace FirstTask
{
    public class Circle : IHasArea
    {
        public double Radius { get; init; }
        public double Area { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can not be less than zero");

            this.Radius = radius;
            this.Area = FindArea();
        }

        public double FindArea()
        {
            var square = Math.PI * Radius * 2;
            return Math.Round(square, 7);
        }
    }
}