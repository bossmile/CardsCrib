using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.Core
{
    public interface ICardsCribDBContext
    {
		DbSet<TModel> ModelSet<TModel>() where TModel : class;

		DbSet<Card> Card { get; set; }
	}
}
