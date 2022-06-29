namespace GeometryLib
{
    public class Calculator
    {
        bool isSquareAngled = false;

        public double Square(double radius)
        {
            double square = Math.PI * radius * radius;
            return square;
        }

        public double Square(double a, double b, double c)
        {
            double p = (a+b+c)/2;
            double square = Math.Sqrt(p*(p-a)*(p-b)+(p-c));
            
            if(a*a==b*b+c*c | b*b==a*a+c*c | c*c==a*a+b*b)
            {
                isSquareAngled = true;
            }
            return square;
        }
    }
}
