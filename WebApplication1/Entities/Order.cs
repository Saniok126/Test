using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.ViewModels;

namespace test.Entities
{
    public class Order : BaseEntity
    {
        public Order() { }
        public Order(NewOrderViewModel model)
        {
            Comment = model.Comment;
            DateBegin = model.DateBegin;
            ClientId = model.ClientId;
            PhoneNumber = model.PhoneNumber;
            Status = Status.New;
        }
        public string Comment { get; set; }

        public DateTime DateBegin { get; set; }

        public virtual Client Client { get; set; }
        public string ClientId { get; set; }

        public string PhoneNumber { get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        New, Approved, Rejected
    }
}
