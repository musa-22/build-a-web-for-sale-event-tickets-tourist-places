using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Eevent.Models
{
    
        /*
         * here product event modeling created. for instance selling tickets for events .... 
         */
    public class ProductEvents
    {

        
        public int Id { get; set; }

        // event title 
        [Required]
        public string Tile { get; set; }


        // short description 
        [Required]
        public string Description { get; set; }

        [Required]
        public double listPrice { get; set; }

        // final price after discount
        [Required]
        public double price { get; set; }

        [Required]
        public string ImageUrl { get; set; }


        // create foreign key between  models 

        public int CategortEeventId { get; set; }
        [Required]
        [ForeignKey("CategortEeventId")]
        public CategoryEevent CategoryEevent { get; set; }

        public int EventsTypesId { get; set; }
        [Required]
        public EventsTypes EventsTypes { get; set; }

    }
}
