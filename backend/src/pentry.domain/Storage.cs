namespace pentry.domain
{
    public class Storage
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Room Room { get; set; }
    }
}
