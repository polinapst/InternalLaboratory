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
            int t = precision.ToString().Split(',')[^1].Length;
            double x = number / degree;
            double x1 = ((degree - 1) * x + (number / Math.Pow(x, degree - 1))) / degree;
            

            while (Math.Abs(x - x1) > precision)
            {
                x = x1;
                //x1 = Math.Round(((degree - 1) * x + (number / Math.Pow(x, degree - 1))) / degree, t, MidpointRounding.AwayFromZero);
                x1 = ((degree - 1) * x + (number / Math.Pow(x, degree - 1))) / degree;
            }

            return Math.Round(x1, t, MidpointRounding.AwayFromZero);
        }
    }
}