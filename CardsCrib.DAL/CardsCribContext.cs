using Microsoft.EntityFrameworkCore;
using System;
using CardsCrib.Models;

namespace CardsCrib.DAL
{
    public class CardsCribContext : DbContext
    {
		public CardsCribContext(DbContextOptions<CardsCribContext> options) : base(options)
		{

		}

		public DbSet<Card> Card { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//test
		}
	}
}
