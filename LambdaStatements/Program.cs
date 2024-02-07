namespace LambdaStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = () => "Greg Esguerra";
            Console.WriteLine(name());

            var FamilyName = string? () => "Esguerra";
            Console.WriteLine(FamilyName());
        }
    }
}
