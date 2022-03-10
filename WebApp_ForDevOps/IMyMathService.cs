namespace WebApp_ForDevOps
{
    public interface IMyMathService
    {
        public double Add(double numberOne, double numberTwo);
        public double Raise(double numberBase, int numberExp);
        public double Half(double number);
    }
}
