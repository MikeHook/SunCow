namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain.Contracts.Repositories;

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
			var categories = _categoryRepository.FindAll();

            return View();
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
