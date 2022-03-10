namespace WebApp_ForDevOps
{
    public class MyMathService : IMyMathService
    {
        public double Add(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }

        public double Half(double number)
        {
            return number / 2;
        }

        public double Raise(double numberBase, int numberExp)
        {
            double result = 1;
            for (int i = 0; i < numberExp; i++)
            {
                result *= numberBase;
            }
            return result;
        }
    }
}
