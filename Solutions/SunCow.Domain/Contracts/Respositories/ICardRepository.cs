using System;
using SharpArch.Domain.PersistenceSupport;
using System.Collections.Generic;

namespace SunCow.Domain.Contracts.Repositories
{
	public interface ICardRepository : IRepository<Card>
	{
		IEnumerable<Card> GetAllBy(Category category);
		Card GetBy(string routeName);
	}
}
