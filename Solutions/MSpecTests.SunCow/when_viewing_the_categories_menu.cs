using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using SunCow.Web.Mvc.Controllers;
using SunCow.Domain.Contracts.Repositories;
using NSubstitute;
using System.Web.Mvc;
using SunCow.Web.Mvc.Controllers.ViewModels;
using SunCow.Domain;

namespace MSpecTests.SunCow
{
	[Subject("Categories menu")]
	public class when_viewing_the_categories_menu
	{
		static ICardRepository _cardRepository { get { return Substitute.For<ICardRepository>(); } }
		static ICategoryRepository _categoryRepository
		{
			get
			{
				var categoryRepository = Substitute.For<ICategoryRepository>();
				categoryRepository.GetAll().ReturnsForAnyArgs(new List<Category>() { new Category() { Name = "Test Cat" } });
				return categoryRepository;
			}
		}

		static CardController cardController;
		static ActionResult result;

		Establish context =
			() =>
			{				
				cardController = new CardController(_categoryRepository, _cardRepository);
			};

		Because of = () => result = cardController.CategoriesMenu();

		It should_contain_at_least_one_category_link
			= () => ((result as ViewResult).ViewData.Model as CategoriesMenuModel).CategoryLinks.ShouldNotBeEmpty();
	}
}
