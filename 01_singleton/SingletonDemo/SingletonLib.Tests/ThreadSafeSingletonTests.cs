using Xunit.Abstractions;

namespace SingletonLib.Tests
{
    public class ThreadSafeSingletonTests
    {
        private readonly ITestOutputHelper _output;
        public ThreadSafeSingletonTests(ITestOutputHelper output)
        {
            _output = output;

            Logger.Clear();
        }

        [Fact]
        public void ReturnsNonNullSingletonInstance()
        {
            var result = ThreadSafeSingleton.Instance;

            Assert.NotNull(result);
            Assert.IsType<ThreadSafeSingleton>(result);

            Logger.Output().ToList().ForEach(h => _output.WriteLine(h));
        }

        [Fact]
        public void OnlyCallsConstructorOnceGivenThreeInstanceCalls()
        {
            // configure logger to slow down the creation longer than the pauses below
            Logger.DelayMilliseconds = 10;

            var result1 = ThreadSafeSingleton.Instance;
            Thread.Sleep(1);
            var result2 = ThreadSafeSingleton.Instance;
            Thread.Sleep(1);
            var result3 = ThreadSafeSingleton.Instance;

            var log = Logger.Output();

            Assert.Equal(3, log.Count(log => log.Contains("Instance")));

            Logger.Output().ToList().ForEach(h => _output.WriteLine(h));
        }
    }
}
