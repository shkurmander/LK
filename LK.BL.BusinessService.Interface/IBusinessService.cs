using LK.BL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.BL.BusinessService
{
    public interface IBusinessService
    {
        void AddAccount(Account account);
        void AddAbonent(Abonent abonent);
        void AddTariff(Tariff tariff);
        void AddTrafficType(TrafficType trType);
        void EditAccount();
        void EditAbonent();
        void EditTariff();
        void EditTrafficType();
        void ViewAccount();
        void ViewAddAbonent();
        void ViewAddTariff();
        void ViewAddTrafficType();
        LKContext GetData();

    }
}
