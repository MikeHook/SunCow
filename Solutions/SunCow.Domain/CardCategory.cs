namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;

    public class CardCategory : Entity
    {
        public CardCategory()
        {
            Cards = new List<Card>();
        }

        public virtual string Name { get; set; }
        public virtual IList<Card> Cards { get; set; }
    }
}