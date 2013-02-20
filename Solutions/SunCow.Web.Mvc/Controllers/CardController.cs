namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain.Contracts.Repositories;
	using SunCow.Web.Mvc.Controllers.ViewModels;

    public class CardController : Controller
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
			return View(new CategoriesModel(categories, Url, "Card"));
        }

		public ActionResult Category(string category)
		{
			return View();
		}

		public ActionResult Details(string cardName)
		{
			return View();
		}

    }
}
