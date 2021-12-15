using System;

namespace Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int ProposalId { get; set; }
        public decimal Discount { get; set; }
        public string Description { get; set; }
    }
}
