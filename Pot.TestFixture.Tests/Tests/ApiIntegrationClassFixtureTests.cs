using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Pot.TestFixture.Tests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot.TestFixture.Tests.Tests
{	
	public class ApiIntegrationClassFixtureTests : IClassFixture<WebApplicationFactory<Program>>
	{
		private readonly WebApplicationFactory<Program> factory;
		private readonly HttpClient client;

		public ApiIntegrationClassFixtureTests(WebApplicationFactory<Program> factory)
		{
			this.factory = factory;
			client = factory.CreateClient();
		}

		[Fact]
		public async void GetWeatherForecast_SuccessResponse()
		{
			var response = await client.GetAsync("WeatherForecast");

			response.Should().NotBeNull();
			response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
		}
	}
}
