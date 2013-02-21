using System;
using SharpArch.Domain.PersistenceSupport;

namespace SunCow.Domain.Contracts.Repositories
{
	public interface ICategoryRepository : IRepository<Category>
	{
		Category GetBy(string routeName);
	}
}
