using System;
using System.Collections.Generic;

namespace Course.Modeles
{
    public partial class Spare
    {
        public int Id { get; set; }
        public string NameSpare { get; set; }
        public int Article { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool? IsDelete { get; set; }
        public byte[] Photo { get; set; }
        public int TypeSpareId { get; set; }

        public TypeSpare TypeSpare { get; set; }
    }
}
