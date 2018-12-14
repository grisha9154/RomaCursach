using Course.Data;
using Course.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services
{
    public  class SpareService
    {
        private ApplicationDbContext context;
        

        public SpareService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public List<Spare> GetAllSpares()
        {
            return context.Spares.Where(x=> !context.Corbs.Any(c => c.SpareId == x.Id) && x.IsDelete!=true).ToList();
        }

        public List<Spare> GetSpareByArticle(int article)
        {
            return context.Spares.Where(x => x.Article == article).ToList();
        }

        public bool CreateSpare(Spare spare)
        {
            spare.DateAdded = DateTime.Now;
            context.Add(spare);
            context.SaveChanges();
            return true;
        }

        public bool UpdateSpare(Spare spares)
        {
            Spare sp = context.Spares.Where(x => x.Id == spares.Id).FirstOrDefault();
            sp.Article = spares.Article;
            sp.DateAdded = spares.DateAdded;
            sp.Description = spares.Description;
            sp.IsDelete = spares.IsDelete;
            sp.NameSpare = spares.NameSpare;
            sp.Photo = spares.Photo;
            sp.Price = spares.Price;
            sp.TypeSpareId = spares.TypeSpareId;
            context.SaveChanges();
            return true;
        }

        public bool DeleteSpare(int spareId)
        {
            Spare spare = context.Spares.Where(x => x.Id == spareId).FirstOrDefault();
            spare.IsDelete = true;
            context.SaveChanges();
            return true;

        }

        public List<Spare> GetSpareByDescription(string like)
        {
            return context.Spares.Where(x => x.Description.Contains("%" + like + "%")).ToList();
        }

        public List<Spare> GetByType(int typeId)
        {
            return context.Spares.Where(x => x.TypeSpareId == typeId).ToList();

        }



    }
}
