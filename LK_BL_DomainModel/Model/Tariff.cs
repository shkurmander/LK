using LK.BL.DAInterface;

namespace LK.BL.Model.DomainModel
{
    public class Tariff 
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Bandwidth { get; set; }

        public string Measure { get; set; }
    }
}
