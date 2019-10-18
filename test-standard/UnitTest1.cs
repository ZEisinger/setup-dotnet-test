using System;
using Xunit;

namespace test_standard
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var instance = new test_dotnet.Class();
            Assert.True(instance.isTrue());
        }
    }
}
