using System;
using SharpArch.Domain.PersistenceSupport;
namespace SunCow.Domain.Contracts.Repositories
{
	public interface ICustomCardRepository : IRepository<CustomCard>
	{
		System.Collections.Generic.IEnumerable<SunCow.Domain.CustomCard> GetAllBy(SunCow.Domain.Category category);
		SunCow.Domain.CustomCard GetBy(string routeName);
	}
}
