
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

        public void AddAccount()
        {
            throw new NotImplementedException();
        }

        public void AddTariff()
        {
            throw new NotImplementedException();
        }

        public void AddTrafficType()
        {
            throw new NotImplementedException();
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
