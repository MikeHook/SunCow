namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain;
	using SunCow.Domain.Contracts.Repositories;
	using SunCow.Web.Mvc.Controllers.ViewModels;
using System;
	using SunCow.Domain.Contracts.Tasks;

    public class CustomController : BaseController
    {
		private readonly ICategoryRepository _categoryRepository;
		private readonly ICardRepository _cardRepository;
		private readonly ICustomCardRepository _customCardRepository;
		private readonly ICustomerRepository _customerRepository;
		private readonly ICustomImageGenerator _customImageGenerator;

		public CustomController(ICategoryRepository categoryRepository,
								ICardRepository cardRepository,
								ICustomCardRepository customCardRepository, 
								ICustomerRepository customerRepository,
								ICustomImageGenerator customImageGenerator)
		{
			_categoryRepository = categoryRepository;
			_cardRepository = cardRepository;
			_customCardRepository = customCardRepository;
			_customerRepository = customerRepository;
			_customImageGenerator = customImageGenerator;
		}

		public ActionResult Index()
		{	
			return View();
		}

        public ActionResult CategoriesMenu()
        {
			var categories = _categoryRepository.GetAll();
			return View(new CategoriesMenuModel(categories, Url, "Custom"));
        }

		public ActionResult Category(string category)
		{
			var cardCategory = _categoryRepository.GetBy(category);
			var cards = _customCardRepository.GetAllBy(cardCategory);

			throw new NotImplementedException();
		}

		public ActionResult Details(string cardName)
		{
			var card = _customCardRepository.GetBy(cardName);

			throw new NotImplementedException();
			//return View(new CardModel(card, this.ImageBasePath));
		}
    }
}
