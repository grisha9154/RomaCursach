using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Course.Modeles
{
    public partial class Corb
    {
        public int Id { get; set; }
        public int SpareId { get; set; }
        public string BuyerId { get; set; }
        public DateTime? DateOfCreate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DateOfSale { get; set; }

        public IdentityUser  Buyer { get; set; }
    }
}
