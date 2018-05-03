﻿using CardsCrib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using CardsCrib.DAL.Repositories;

namespace CardsCrib.Service.Services
{
    class CardService : ICardService
    {
		private ICardRepository _cardRepository;

		public CardService(ICardRepository cardRepository)
		{
			_cardRepository = cardRepository;
		}

		public IEnumerable<Card> GetCardList()
		{
			return _cardRepository.GetCardList();
		}
	}
}
