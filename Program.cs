using ImmutableRecord;
using LambaExpression;

class AnotherSampleClass
{
    static public void Main(String[] args){
        Console.WriteLine("Main Method");
        var person = new Person("alfa", "beta");
        // person.FirstName = "fia"; cannot change property of immutable record
        var person2 = new Person2();
        Console.WriteLine(person2.FirstName is String); // true 
        Console.WriteLine(person2.FirstName is null); // false

        var immutablePoint = new ImmutablePoint(3,2,2);
        // immutablePoint.X = 32; immutable
        Console.WriteLine(immutablePoint);
        var mutablePoint = new MutablePoint();
        // mutablePoint.X = 32; //immutable
        Console.WriteLine(mutablePoint);

        DataMeasurement dataMeasurement = new(DateTime.Now, 32.3);
        dataMeasurement.Measurement = 32323.32;
        Console.WriteLine(dataMeasurement);

        // Lambda
        Lambda lambda = new Lambda();
        var game = new VariableCaptureGame();

        int gameInput = 5;
        game.Run(gameInput);

        int jTry = 10;
        bool result = game.isEqualToCapturedLocalVariable(jTry);
        Console.WriteLine($"Captured local variable is equal to {jTry}: {result}");

        int anotherJ = 3;
        game.updateCapturedLocalVariable(anotherJ);

        bool equalToAnother = game.isEqualToCapturedLocalVariable(anotherJ);
        Console.WriteLine($"Another lambda observes a new value of captured variable: {equalToAnother}");
        
    }
}