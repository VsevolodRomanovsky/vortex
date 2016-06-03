using System.Data.Entity;


namespace TurnstileCodeFirst
{
    internal class TurnstileContext : DbContext
    {

        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<Visitor> Visitors { get; set; }
    }
}
