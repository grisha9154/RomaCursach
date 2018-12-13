using Course.Data;
using Course.Modeles;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services
{
    public class StoreService
    {
        private ApplicationDbContext context;


        public StoreService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool ToOrder(int article, string userId)
        {
            Spare order = context.Spares.Where(x => x.Article == article).FirstOrDefault();
            Corb corb = new Corb();
            corb.SpareId = order.Id;
            corb.DateOfCreate = DateTime.Now;
            corb.BuyerId = userId;
            corb.IsActive = true;
            corb.DateOfSale = null;
            context.Add(corb);
            context.SaveChanges();
            return true;
            
        }

        //public List<Spare> GetCorbUsers(string userId)
        //{
        //    var query = from 

        //    return context.Corbs.Where(c => context.Spares.Any(s => s.Id == c.SpareId) && c.BuyerId == userId).ToList();
        //}

        //public List<Spare> GetKorzina()
        //{
            
        //}


    }
}
