namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;
    using System.IO;

    public class Template : Entity
    {
        //Default constructor needed for NHibernate
        public Template() { }
          
        public Template(Category category)
        {
            Category = category;  
        }

        public virtual Category Category { get; set; }
        public virtual string CardName { get; set; }
        public virtual string ThumbnailImageName { get; set; }
        public virtual string OutsideImageName { get; set; }
        public virtual string InsideImageName { get; set; }
        public virtual bool HasOutsideMessage { get; set; }

        public virtual string GetImagePath(string imageBasePath, string imageName)
        {
            string templatesDirectory = "Templates\\";
            return Path.Combine(imageBasePath, templatesDirectory, Category.ImageDirectory, imageName);
        }        

        //Implement this if relationship is required
        //public virtual IList<Card> Cards { get; set; }
    }
}