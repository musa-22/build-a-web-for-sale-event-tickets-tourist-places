using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Eevent.Models
{
    public class EventsTypes
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Event Type")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


    }
}
