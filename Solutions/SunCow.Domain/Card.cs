namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.IO;

    public class Card : Entity
    {
        //Default constructor needed for NHibernate
        public Card() { }

        //Note - In full application would be better if cards could be created without a customer, limit for brevity in prototype   
        public Card(Customer customer, CardTemplate cardTemplate, CardCategory category)
        {
            Customer = customer;
            CardTemplate = cardTemplate;
            Category = category;
        }

        /// <summary>
        /// The full image paths will be made by convention, use the GetImagePath and GetThumbnailPath methods 
        /// </summary>      

        public virtual string OutsideMessage { get; set; }
        public virtual string Salutation { get; set; }
        public virtual string InsideMessage { get; set; }
        public virtual string SignOff { get; set; }
        public virtual decimal Price { get; set; }

        public virtual CardTemplate CardTemplate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CardCategory Category { get; set; }

        public virtual string GetImagePath(string imageBasePath, string imageSubDirectory) 
        {
            return Path.Combine(imageBasePath, imageSubDirectory, ImageDirectory, ImageName);             
        }

        public virtual string GetThumbnailPath(string imageBasePath, string thumbnailSubDirectory)
        {
            return Path.Combine(imageBasePath, thumbnailSubDirectory, ImageDirectory, ImageName);
        }

        protected virtual string ImageDirectory 
        {
            get { return string.Format("{0}-{1}\\", Customer.LastName, Customer.Id); }        
        }

        protected virtual string ImageName 
        { 
            //Note - not sure if png will be the best format, depends what we can get out of the image generator
            get {return string.Format("{0}.png", Id); }
        }
    }
}