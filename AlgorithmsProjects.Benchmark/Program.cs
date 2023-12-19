// See https://aka.ms/new-console-template for more information
using AlgorithmsProjects.Benchmark;
using BenchmarkDotNet.Running;

Console.WriteLine("Hello, World!");


BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
BenchmarkRunner.Run<TheEasiestBenchmark>();

