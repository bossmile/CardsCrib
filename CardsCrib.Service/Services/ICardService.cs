using CardsCrib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.Service.Services
{
    interface ICardService
    {
		IEnumerable<Card> GetCardList();
	}
}
