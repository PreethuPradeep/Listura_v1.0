using System.ComponentModel.DataAnnotations.Schema;

namespace Listura_v1._0.Models
{
    public class TaskLabel
    {
        public int LabelId { get; set; }
        public int TaskItemId { get; set; }
        [ForeignKey("LabelId")]
        public Label Label { get; set; }
        [ForeignKey("TaskItemId")]
        public TaskItem TaskItem { get; set; }
    }
}
