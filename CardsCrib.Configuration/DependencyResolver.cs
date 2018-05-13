using CardsCrib.DAL;
using CardsCrib.DAL.Repositories;
using CardsCrib.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.Configuration
{
    public static class DependencyResolver
    {
		public static void RegisterDependency(IServiceCollection _ServiceCollection, string connectionString)
		{
			_ServiceCollection.AddDbContext<CardsCribContext>(options => options.UseSqlServer(connectionString));

			//Adding repository DI
			//_ServiceCollection.AddTransient<ICardRepository, ICardRepository>();
		}

	}
}
