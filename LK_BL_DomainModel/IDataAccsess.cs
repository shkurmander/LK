using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.BL.DomainModel
{
    public interface IDataAccsess
    {
        void AddAccount();
        void AddAbonent(Abonent abonent);
        void AddTariff();
        void AddTrafficType();
        void EditAccount();
        void EditAbonent();
        void EditTariff();
        void EditTrafficType();
        T GetData<T>() where T : class;


    }
}
