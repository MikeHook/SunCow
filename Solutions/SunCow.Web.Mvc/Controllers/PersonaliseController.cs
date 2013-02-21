namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain;
	using SunCow.Domain.Contracts.Repositories;
	using SunCow.Web.Mvc.Controllers.ViewModels;
using System;
	using SunCow.Domain.Contracts.Tasks;

    public class PersonaliseController : BaseController
    {
		private readonly ICategoryRepository _categoryRepository;
		private readonly ICardRepository _cardRepository;
		private readonly ICustomCardRepository _customCardRepository;
		private readonly ICustomerRepository _customerRepository;
		private readonly ICustomImageGenerator _customImageGenerator;

		public PersonaliseController(ICategoryRepository categoryRepository,
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

		[HttpPost]
		public ActionResult PersonaliseCard(PersonaliseModel model)
		{
			var card = _cardRepository.GetBy(model.CardRouteName);
			var customer = _customerRepository.GetSampleCustomer();

			var customCard = new CustomCard(customer, card) 
			{
				OutsideMessage = model.OutsideMessage,
				InsideMessage = model.InsideMessage,
				Salutation = model.Salutation,
				SignOff = model.SignOff,				
			};

			customCard = _customCardRepository.SaveOrUpdate(customCard);

			
			string templateImageServerPath = this.HttpContext.Server.MapPath(customCard.Card.GetImagePath(this.ImageBasePath, customCard.Card.BlankInsideImageName));
			string customImageServerPath = this.HttpContext.Server.MapPath(customCard.GetInsideImagePath(this.ImageBasePath));

			_customImageGenerator.Generate(customCard, templateImageServerPath, customImageServerPath);

			return RedirectToAction("Details", "Custom", new { cardId = customCard.Id });
		}
    }
}
