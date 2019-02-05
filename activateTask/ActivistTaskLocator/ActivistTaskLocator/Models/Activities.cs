using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;



namespace ActivistTaskLocator.Models
{
    
    public class Activities
    {
        public int ID { get; set; }
        [Required]
        public string Activity { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public string Organizer { get; set; }
        
        [StringLength(3)]
        public string Attending { get; set; }
    }

    public class ActivityDBContext : DbContext
    {
        public DbSet<Activities> ActivityList { get; set; }
    }

}
