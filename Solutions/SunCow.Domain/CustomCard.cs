namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.IO;

    public class CustomCard : Entity
    {
        //Default constructor needed for NHibernate
        public CustomCard() { }

        //Note - In full application would be better if cards could be created without a customer, limit for brevity in prototype   
		public CustomCard(Customer customer, Card card)
        {
            Customer = customer;
            Card = card;     
        }

        /// <summary>
        /// The full image paths will be made by convention, use the GetImagePath and GetThumbnailPath methods 
        /// </summary>      

        public virtual string OutsideMessage { get; set; }
        public virtual string Salutation { get; set; }
        public virtual string InsideMessage { get; set; }
        public virtual string SignOff { get; set; }
        
        public virtual Card Card { get; set; }
        public virtual Customer Customer { get; set; }

		/// <summary>
		/// The route name used in the website URL segments
		/// </summary>
		//TODO - Add a unique constraint to this property & ensure only allowed characters are used in the name	
		public virtual string RouteName { get; set; }

        public virtual string GetOutsideImagePath(string imageBasePath) 
        {
            return CustomerImagePath(imageBasePath, string.Format("{0}-outside.png", Id));             
        }

        public virtual string GetInsideImagePath(string imageBasePath)
        {
            return CustomerImagePath(imageBasePath, string.Format("{0}-inside.png", Id));
        }

        public virtual string GetThumbnailPath(string imageBasePath)
        {
            return CustomerImagePath(imageBasePath, string.Format("{0}-tn.png", Id));
        }

        //TODO - Check whether this works when directories don't include / separators
        protected virtual string CustomerImagePath(string imageBasePath, string imageName)
        {
            string customCardsDirectory = "Custom//";            

            return Path.Combine(imageBasePath, customCardsDirectory, Customer.ImageDirectory, imageName);           
        }
    }
}