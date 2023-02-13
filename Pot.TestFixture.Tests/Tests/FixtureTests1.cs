using Pot.TestFixture.Tests.Fixtures;

namespace Pot.TestFixture.Tests.Tests
{
    [Collection(nameof(XptoFixtureCollection))]
    public class FixtureTests1
    {
        private readonly XptoFixture xptoFixture;

        public FixtureTests1(XptoFixture xptoFixture)
        {
            this.xptoFixture = xptoFixture;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal("Arielle", xptoFixture.Name);
        }

        [Fact]
        public void TestRename()
        {
            xptoFixture.SetName("Rodolfo");

            Assert.Equal("Rodolfo", xptoFixture.Name);
        }
    }
}