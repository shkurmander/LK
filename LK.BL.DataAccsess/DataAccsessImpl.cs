
using LK.BL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.BL.DataAccsess
{
    public class DataAccsessImpl : IDataAccsess
    {
        

        public void AddAbonent()
        {
            /*Abonent abon = new Abonent
            {
                FirstName = name,
                Patronimyc = patron

            };*/

        }

        public void AddAbonent(Abonent abonent)
        {
            LKContext db = new LKContext();
            db.Abonent.Add(abonent);
            db.SaveChanges();
        }

        public void AddAccount(Account account)
        {
            LKContext db = new LKContext();
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void AddTariff(Tariff tarrif)
        {
            LKContext db = new LKContext();
            db.Tariffs.Add(tarrif);
            db.SaveChanges();
        }

        public void AddTrafficType(TrafficType trType)
        {
            LKContext db = new LKContext();
            db.TrafficTypes.Add(trType);
            db.SaveChanges();
        }

        public void EditAbonent()
        {
            throw new NotImplementedException();
        }

        public void EditAccount()
        {
            throw new NotImplementedException();
        }

        public void EditTariff()
        {
            throw new NotImplementedException();
        }

        public void EditTrafficType()
        {
            throw new NotImplementedException();
        }

        public LKContext GetData() 
        {
            LKContext db = new LKContext();
            return db;
        }
    }
}
