using System;

namespace pentry.domain
{
    public class WeightedItem : IItem, IHaveWeight
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Current { get; set; }
        public double Original { get; set; }
        public double Level => Original / Current;
    }
}
