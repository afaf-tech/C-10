using System;
//File scoped namespace declarations are available with C# 10.
namespace SampleFileScopedNamespace;

class SampleClass { }

interface ISampleInterface { }

public readonly struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; init; }
    public double Y { get; init; }

    public override string ToString() => $"({X}, {Y})";
}

enum SampleEnum { a, b }

delegate void SampleDelegate(int i);