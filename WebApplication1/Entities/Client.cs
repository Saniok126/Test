using System.Collections.Generic;

namespace test.Entities
{
    public class Client : BaseEntity
    {
        public Client() { }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
