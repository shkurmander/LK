

using System.Collections.Generic;

namespace LK.BL.DomainModel
{
    public class Tariff 
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Bandwidth { get; set; }
        public string Measure { get; set; }
        //Ссылка на аккаунты
        public List<Account> Accounts { get; set; }

    }
}
