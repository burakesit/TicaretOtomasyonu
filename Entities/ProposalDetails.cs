﻿namespace Entities
{
    public class ProposalDetails
    {
        public int Id { get; set; }
        public int ProposalId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
