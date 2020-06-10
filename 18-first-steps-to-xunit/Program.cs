using System;

namespace first_steps_to_xunit
{
    class Program
    {
        static void Main(string[] args)
        {
            new TestCaseTests("TestRunning").Run();
        }
    }

    public class WasRun : TestCase<WasRun>
    {
        public bool wasRun { get; set; }

        public WasRun(string name) : base(name)
        {
        }

        public void TestMethod()
        {
            this.wasRun = true;
        }
    }

    public class TestCase<T> where T : class {
        public string Name { get; set; }
        public TestCase(string name){
            this.Name = name;
        }
        public void Run(){
            var method = typeof(T).GetMethod(Name);
            method.Invoke(this, new object[]{});
        }
    }

    public class TestCaseTests : TestCase<TestCaseTests> {

        public TestCaseTests(string name) : base(name)
        {
            
        }
        public void TestRunning(){
            var test = new WasRun("TestMethod");
            System.Console.WriteLine(test.wasRun);
            // Assert.False(test.wasRun);
            test.Run();
            System.Console.WriteLine(test.wasRun);
            // Assert.True(test.wasRun);
        }
    }
}
