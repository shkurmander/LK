using LK.BL.DAInterface;

namespace LK.BL.Model.DomainModel
{
    class AbonentTraffic : ITraffic
    {
        public int id { get; set; }
        public TrafficType Type { get; set; }
        public long Ammount { get; set; }

    }
}
