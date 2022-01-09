namespace LambaExpression
{
    class Lambda{
        public Lambda(){
            var parse = (string s) => int.Parse(s);
            Console.WriteLine(parse("323232"));
            // var choose = (bool b) => b ? 1 : "two"; // ERROR: Can't infer return type
            // allowed in c#10 with parenthesize the input paremeter
            var choose = object (bool b) => b ? 1 : "two"; // Func<bool, object>
            Console.WriteLine(choose(true));

            // attributes to a lambda expression.
            // Console.WriteLine("[Attributes]");
            // Func<string, int> parse = [Example(1)] (s) => int.Parse(s);
            // var choose = [Example(2)][Example(3)] object (bool b) => b ? 1 : "two";
            // Console.WriteLine(parse);
            // Console.WriteLine(choose);
        }
    }

     public class VariableCaptureGame
    {
        internal Action<int> updateCapturedLocalVariable;
        internal Func<int, bool> isEqualToCapturedLocalVariable;

        public void Run(int input)
        {
            int j = 0;

            updateCapturedLocalVariable = x =>
            {
                j = x;
                bool result = j > input;
                Console.WriteLine($"{j} is greater than {input}: {result}");
            };

            isEqualToCapturedLocalVariable = x => x == j;

            Console.WriteLine($"Local variable before lambda invocation: {j}");
            updateCapturedLocalVariable(10);
            Console.WriteLine($"Local variable after lambda invocation: {j}");
        }
    }

}