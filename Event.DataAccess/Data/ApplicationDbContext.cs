using Eevent.Models;

using Microsoft.EntityFrameworkCore;

namespace Event.DataAccess;


/**
 * configure DB and install packages  mircosoft entity frameworl
 * Microsoft.EntityFrameworkCore
 * 
 * 
 * 
 */


public class ApplicationDbContext : DbContext
{

    /*
     * create constructor and pass Dbcontext inside  the para to configure 
     */

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // here I created the database table here 

    public DbSet<CategoryEevent>  categoryEevents { get; set; }

    public DbSet<EventsTypes> eventsTypes { get; set; }


}
