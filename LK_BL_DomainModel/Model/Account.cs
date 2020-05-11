
using LK.BL.DAInterface;

namespace LK.BL.Model.DomainModel
{
    public class Account : IAccount
    {
        public int id { get; set; }

        public string UserName { get; set; }
        public string Pass { get; set; }
        public int Number { get; set; }
        public int MyProperty { get; set; }
        public IAbonent Abonent { get; set; }

    }
}
