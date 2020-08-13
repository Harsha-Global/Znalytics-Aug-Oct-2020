//Class Library
public class Sample
{
    //method
    public double GetAreaOfCircle(double radius)
    {
        double area = GetProduct(System.Math.PI, GetProduct(radius, radius));

        //local function
        static double GetProduct(double a, double b)
        {
            return a * b;
        }

        return area;
    }
}

