using System.ComponentModel.DataAnnotations;

namespace TaskList.Domain
{
    public class TaskItem : BaseEntity
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz!")]
        [StringLength(255)]
        [Display(Name = "Yapılacak İş")]
        public string TaskName { get; set; }
        [Display(Name = "Tamamlandı Mı?")]
        public bool IsCompleted { get; set; } = false;
    }
}
