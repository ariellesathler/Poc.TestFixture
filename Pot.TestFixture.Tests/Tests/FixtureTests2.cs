using Pot.TestFixture.Tests.Fixtures;

namespace Pot.TestFixture.Tests.Tests
{
    [Collection(nameof(XptoFixtureCollection))]
    public class FixtureTests2
    {
        private readonly XptoFixture xptoFixture;

        public FixtureTests2(XptoFixture xptoFixture)
        {
            this.xptoFixture = xptoFixture;
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("Arielle", xptoFixture.Name);
        }
    }
}