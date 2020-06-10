

using System.Collections.Generic;

namespace LK.BL.DomainModel
{
    public class Account
    { 
        public int id { get; set; }
        public long Number { get; set; }  
        public string Login { get; set; }
        public string Password { get; set; }             
        public ICollection<Abonent> Abonent { get; set; }
        public ICollection<Tariff> Tariff { get; set; }

    }
}
