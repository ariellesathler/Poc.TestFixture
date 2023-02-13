using Microsoft.AspNetCore.Mvc.Testing;
using Pot.TestFixture.Tests.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot.TestFixture.Tests.Fixtures
{
	[CollectionDefinition(nameof(ApiFixtureCollection))]
	public class ApiFixtureCollection : ICollectionFixture<ApiFixture>
	{
	}

	public class ApiFixture : IDisposable
	{
		public readonly ApiFactory apiFactory;
		public readonly HttpClient httpClient;

		public ApiFixture()
		{
			var clientOptions = new WebApplicationFactoryClientOptions
			{
				BaseAddress = new Uri("http://localhost")
			};

			apiFactory = new ApiFactory();
			httpClient = apiFactory.CreateClient(clientOptions);
		}

		public void Dispose()
		{
			apiFactory.Dispose();
			httpClient.Dispose();
		}
	}
}
