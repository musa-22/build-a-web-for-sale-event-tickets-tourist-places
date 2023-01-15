using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Eevent.Models
{


    /*
     * 
     * 1- creating database model for category event 
     *  2- install microsft entity & sql server 
     *  
     * later will add primary key for id and more validation will be applied later to this 
     * 
     * 
     */

                
    public class CategoryEevent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100 only!!")]
        public int DisplayEventOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
