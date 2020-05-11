

using LK.BL.DAInterface;
using System.Collections.Generic;


namespace LK.BL.Model.DomainModel
{
    public class Abonent : IAbonent
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string Patronimyc { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string Passport { get; set; }
        public ICollection<IAccount> Accounts { get; set; }
        public ITarrif Tarrif { get; set; }
    }

}
