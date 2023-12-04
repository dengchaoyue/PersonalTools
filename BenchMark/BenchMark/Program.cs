namespace BenchMark
{
    using BenchmarkDotNet.Running;
    using static Benchmark.BenchMark;

    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<EnumAnyTest>();
        }
    }
}