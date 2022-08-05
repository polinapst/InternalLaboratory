namespace Module3
{
    //public interface IFindNthRoot
    //{
     //   public double FindNthRoot(double number, int degree, double precision);
    //}

    public static class NewtonsMethod
    {
        public static double FindNthRoot(double number, int degree, double precision)
        {
            double x = number / degree;
            double x1 = ((degree - 1) * x + (number / Math.Pow(x, degree - 1))) / degree;

            while (Math.Abs(x - x1) > precision)
            {
                x = x1;
                x1 = ((degree - 1) * x + (number / Math.Pow(x, degree - 1))) / degree;
            }

            return x1;
        }
    }
}