using FluentAssertions;
using Pot.TestFixture.Tests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot.TestFixture.Tests.Tests
{
	[Collection(nameof(ApiFixtureCollection))]
	public class ApiIntegrationCollectionFixtureTests
	{
		private readonly ApiFixture apiFixture;

		public ApiIntegrationCollectionFixtureTests(ApiFixture apiFixture)
		{
			this.apiFixture = apiFixture;
		}

		[Fact]
		public async void GetWeatherForecast_SuccessResponse()
		{
			var response = await apiFixture.httpClient.GetAsync("WeatherForecast");

			response.Should().NotBeNull();
			response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
		}
	}
}
