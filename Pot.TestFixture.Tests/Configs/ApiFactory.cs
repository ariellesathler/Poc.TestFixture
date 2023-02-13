using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pot.TestFixture.Tests.Configs
{
	public class ApiFactory : WebApplicationFactory<Program>
	{
		protected override void ConfigureClient(HttpClient client)
		{	
			base.ConfigureClient(client);
		}

		protected override void ConfigureWebHost(IWebHostBuilder builder)
		{
			base.ConfigureWebHost(builder);
		}
	}

}
