        public delegate void MethodHandlerA();
        public delegate int MethodHandlerB(int x, int y);

        public class MathCalculator
        {
            public void DoTask()
            {
                Console.WriteLine("calculator DoTask");
            }
            public int Add(int x , int y)
            {
                Console.WriteLine(x + "," + y);
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                Console.WriteLine(x + "," + y);
                return x * y;
            }
            public int divide(int x, int y)
            {
                Console.WriteLine(x + "," + y);
                return x / y;
            }
            public string GetModel()
            {
                return "X500";
            }
        }
public class DelegateProg
{


    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask; //new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Add;// new MethodHandlerB(mc.Add);
        MethodHandlerB methodHandlerTwo = mc.Multiply;// new MethodHandlerB(mc.Multiply);
        //MethodHandlerB methodHandlerThree = new MethodHandlerB(mc.Divide);
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int multiplyResult = methodHandlerTwo(20, 5);
        Console.WriteLine(multiplyResult);
    }
    public static void TestTwo()
    {
        MathCalculator mc=new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Multiply;
        methodHandlerB(100, 50);
    }
}


