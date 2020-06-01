


using System;
using System.Collections.Generic;


namespace LK.BL.DomainModel
{
    public class Abonent 
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string Patronimyc { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public ICollection<Account> Accounts { get; set; }
        
    }

}
