

using System.Collections.Generic;

namespace LK.BL.DomainModel
{
    public class Account
    { 
        public int id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public int Number { get; set; }        
        public ICollection<Abonent> Abonent { get; set; }
        public ICollection<Tariff> Tarrif { get; set; }

    }
}
