using System;
using System.Collections.Generic;

namespace Course.Modeles
{
    public partial class TypeSpare
    {
        public TypeSpare()
        {
            Spare = new HashSet<Spare>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public ICollection<Spare> Spare { get; set; }
    }
}
