//C#9
namespace ImmutableRecord;
public record Person(string FirstName, string LastName);

// immutable after init
public record Person2
{
    public string FirstName { get; init; } = "Firstname";
    public string LastName { get; init; } = default!;
};

// C#10
/* In C# 10 and later, you can define record struct types using either positional parameters, 
or standard property */

/* You can declare value type records using the record struct or readonly record struct declarations. You can now clarify 
that a record is a reference type with the record class declaration. */

public readonly record struct ImmutablePoint(double X, double Y, double Z);

public record struct MutablePoint
{
    public double X {  get; init; }
    public double Y {  get; init; }
    public double Z {  get; init; }
}

//Positional properties are immutable in a record class and a readonly record struct
// mutable due to not existing readonly keyword
public record struct DataMeasurement(DateTime TakenAt, double Measurement);
