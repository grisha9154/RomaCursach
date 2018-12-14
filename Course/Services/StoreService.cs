using Course.Data;
using Course.Modeles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            //Spare order = context.Spares.Where(x => x.Article == article).FirstOrDefault();
            //Corb corb = new Corb();
            //corb.SpareId = order.Id;
            //corb.DateOfCreate = DateTime.Now;
            //corb.BuyerId = userId;
            //corb.IsActive = true;
            //corb.DateOfSale = null;
            //context.Add(corb);
            //context.SaveChanges();
            
            var res = context.Database.ExecuteSqlCommand("insert into Corbs values((select Id from Spares where Article ={0}), {1}, GETDATE(),1, null);", article, userId);
            return true;
            
        }

       

        public List<Spare> GetKorzina(string userId)
        {
            SqlParameter param = new SqlParameter("userId", userId);
            var spares = context.Spares.FromSql("select Spares.* from Spares left join Corbs on Spares.Id = Corbs.SpareId Where Corbs.BuyerId = @userId and DateOfSale is null", param).ToList();
            return spares;
        }


        public bool DeleteInCorb(int spareId)
        {
          
            var res = context.Database.ExecuteSqlCommand("Delete from Corbs where SpareId = {0}", spareId);
            return true;

        }

        public bool Buy(string userId)
        {
            var res = context.Database.ExecuteSqlCommand("update Corbs set DateOfSale = {0} where Corbs.BuyerId = {1}", DateTime.Now, userId);
            return true;
        }




    }
}
