using System.Collections.Generic;

namespace LK.BL.DAInterface
{
    interface IAbonent
    {
        string FirstName { get; set; }
        string Patronimyc { get; set; }
        string LastName { get; set; }
        ICollection<IAccount> Accounts { get; set; }
        ITarrif Tarrif { get; set; }


    }
}
