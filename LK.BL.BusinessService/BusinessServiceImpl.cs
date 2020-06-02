

using LK.BL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.BL.DataAccsess;

namespace LK.BL.BusinessService
{
    public class BusinessServiceImpl : IBusinessService
    {
        IDataAccsess da;       
        public void AddAbonent()
        {
            throw new NotImplementedException();
        }

        public void AddAbonent(Abonent abonent)
        {
            da = new DataAccsessImpl();
            da.AddAbonent(abonent);
        }

        public void AddAccount()
        {
            throw new NotImplementedException();
        }

        public void AddTariff()
        {
            throw new NotImplementedException();
        }

     
        public void AddTrafficType(TrafficType trType)
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

        public void ViewAccount()
        {
            throw new NotImplementedException();
        }

        public void ViewAddAbonent()
        {
            throw new NotImplementedException();
        }

        public void ViewAddTariff()
        {
            throw new NotImplementedException();
        }

        public void ViewAddTrafficType()
        {
            throw new NotImplementedException();
        }
    }
}
