using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot.TestFixture.Tests.Fixtures
{
    [CollectionDefinition(nameof(XptoFixtureCollection))]
    public class XptoFixtureCollection : ICollectionFixture<XptoFixture>
    {
    }

    public class XptoFixture : IDisposable
    {
        public string Name;

        public XptoFixture()
        {
            Name = "Arielle";
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void SetName(string name)
        {
            Name = name;
        }

    }
}
