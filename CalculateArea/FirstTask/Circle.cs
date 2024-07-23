namespace FirstTask
{
    public class Circle : IArea
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can not be less than zero");

            this.Radius = radius;
        }

        public double TryFindArea()
        {
            var square = Math.PI * Radius * 2;
            return Math.Round(square, 7);
        }
    }
}