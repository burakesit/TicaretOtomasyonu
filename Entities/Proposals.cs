using System;

namespace Entities
{
    public class Proposals
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public decimal Discount { get; set; }
        public DateTime ProposalDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Description { get; set; }
    }
}
