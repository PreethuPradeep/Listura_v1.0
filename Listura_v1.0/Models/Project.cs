using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class Project:BaseEntity
    {
        //public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string? Theme { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser AppUser { get; set; }
        public ICollection<Section> Sections { get; set; }
    }
}
//represents a group of related tasks
//belongs to one appuser
//contains many sections