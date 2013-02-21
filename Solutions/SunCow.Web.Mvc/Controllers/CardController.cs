namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain.Contracts.Repositories;
	using SunCow.Web.Mvc.Controllers.ViewModels;

    public class CardController : BaseController
    {
		private readonly ICategoryRepository _categoryRepository;
		private readonly ICardRepository _cardRepository;

		public CardController(ICategoryRepository categoryRepository, ICardRepository cardRepository)
		{
			_categoryRepository = categoryRepository;
			_cardRepository = cardRepository;
		}

		public ActionResult Index()
		{	
			return View();
		}

        public ActionResult CategoriesMenu()
        {
			var categories = _categoryRepository.GetAll();
			return View(new CategoriesMenuModel(categories, Url, "Card"));
        }

		public ActionResult Category(string category)
		{
			var cardCategory = _categoryRepository.GetBy(category);
			var cards = _cardRepository.GetAllBy(cardCategory);

			var model = new CategoryModel(cardCategory, cards, this.ImageBasePath);
			return View(model);
		}

		public ActionResult Details(string cardName)
		{
			var card = _cardRepository.GetBy(cardName);

			return View(new CardModel(card, this.ImageBasePath));
		}
    }
}
