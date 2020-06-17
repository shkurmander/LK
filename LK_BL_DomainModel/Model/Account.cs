

using System.Collections.Generic;

namespace LK.BL.DomainModel
{
    public class Account
    { 
        public int id { get; set; }
        public long Number { get; set; }  
        public string Login { get; set; }
        public string Password { get; set; }
        //Ссылка на тариф
        public Tariff AccTariff { get; set; }
        //Ссылка на абонента
        public Abonent AccAbonent { get; set; }
        

    }
}
