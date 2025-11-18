using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class Label:BaseEntity
    {
        //public int LabelId { get; set; }
        public string LabelName { get; set; }
        public string color { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public AppUser AppUser { get; set; }
        public ICollection<TaskLabel> TaskLabel { get; set; }
    }
}
//belongs to a user
//each user have their own personalised label set
// connects to many task items
//many to many
