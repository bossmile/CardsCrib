using Microsoft.EntityFrameworkCore;
using System;
using CardsCrib.Core;
using System.Collections.Generic;

namespace CardsCrib.DAL
{
    public class CardsCribContext : DbContext, ICardsCribDBContext
    {
		public CardsCribContext(DbContextOptions<CardsCribContext> options) : base(options)
		{
		}

		public virtual DbSet<TModel> ModelSet<TModel>() where TModel : class
		{
			return Set<TModel>();
		}

		public DbSet<Card> Card { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		}
	}
}
