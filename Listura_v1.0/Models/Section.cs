namespace Listura_v1._0.Models
{
    public class Section:BaseEntity
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int UserId { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}
