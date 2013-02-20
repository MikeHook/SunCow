using System;
using SharpArch.Domain.PersistenceSupport;

namespace SunCow.Domain.Contracts.Repositories
{
	public interface ICardRepository : ILinqRepository<Card>
	{
		SunCow.Domain.Card GetBy(string routeName);
	}
}
