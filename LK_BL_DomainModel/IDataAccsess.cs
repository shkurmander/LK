using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.BL.DomainModel
{
    public interface IDataAccsess
    {
        void AddAccount(Account account);
        void AddAbonent(Abonent abonent);
        void AddTariff(Tariff tariff);
        void AddTrafficType(TrafficType trType);
        void EditAccount();
        void EditAbonent();
        void EditTariff();
        void EditTrafficType();
        //T GetData<T>() where T : class;
        LKContext GetData();



    }
}
