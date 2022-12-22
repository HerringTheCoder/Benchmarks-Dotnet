using BenchmarkDotNet.Running;
using EFCoreBenchmarks.SplitQuery;

BenchmarkRunner.Run<SplitBehaviorSqlServerBenchmark>();