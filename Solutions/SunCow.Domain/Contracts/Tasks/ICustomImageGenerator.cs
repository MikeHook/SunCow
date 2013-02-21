using System;
namespace SunCow.Domain.Contracts.Tasks
{
	public interface ICustomImageGenerator
	{
		void Generate(CustomCard customCard, string templateServerPath, string customImageServerPath);
	}
}
