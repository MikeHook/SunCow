namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;

    public class Customer : Entity
    {
        public Customer()
        {
            Cards = new List<Card>();
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual IList<Card> Cards { get; set; }
    }
}