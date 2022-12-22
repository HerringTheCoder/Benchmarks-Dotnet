// See https://aka.ms/new-console-template for more information

using System;
using BenchmarkDotNet.Running;
using Benchmarks.Cast;

Console.WriteLine("Hello, World!");

// BenchmarkRunner.Run<ExactCountBenchmark>();
BenchmarkRunner.Run<CastBenchmark>();