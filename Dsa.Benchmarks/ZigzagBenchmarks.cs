namespace Dsa.Benchmarks
{
    using BenchmarkDotNet.Attributes;
    using Dsa.LeetCode.Practice;
    using ZigzagSln = Dsa.LeetCode.Solution.Zigzag;

    [MemoryDiagnoser]
    public class ZigzagBenchmarks
    {
        private const string LengthyString = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        private const int Rows = 4;

        [Benchmark]
        public void MyZigzag()
        {
            Zigzag.Convert(LengthyString, Rows);
        }

        [Benchmark]
        public void ZigzagSln1()
        {
            ZigzagSln.Convert1(LengthyString, Rows);
        }

        /* Results
            | Method     | Mean     | Error   | StdDev  | Gen0   | Gen1   | Allocated |
            |----------- |---------:|--------:|--------:|-------:|-------:|----------:|
            | MyZigzag   | 104.8 ns | 2.08 ns | 3.71 ns | 0.0526 |      - |     440 B |
            | ZigzagSln1 | 194.2 ns | 3.88 ns | 6.05 ns | 0.1194 | 0.0002 |    1000 B | */
    }
}
