using SampleNamespace.NestedStatic;
using SampleFileScopedNamespace;
class AnotherSampleClass
{
    static public void Main(String[] args){
        Console.WriteLine("Main Method");
        // call a static method in a nested namespace
        NestedNameSpaceClass.SayHello();
        // call file scoped namespace declaration
        var sampleStruct = new Coords(2,2);
        Console.WriteLine(sampleStruct.X);

    }
}