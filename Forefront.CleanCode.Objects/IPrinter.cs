namespace Forefront.CleanCode.Objects
{
    public interface IPrinter
    {
        void Print(string output);
        void PrintLine(string output, params object[] args);
        void PrintLine(string output);
    }
}