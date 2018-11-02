using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkWeb
{
	public partial class XingContext: DbContext
	{
	public XingEntities()
	   : base("name=XingEntities")
	   {
	   }
	protected override void OnModelCreating(DbModelBuilder modelBuilder)
	{
	}
	public virtual DbSet<Worker> Workers {get; set;}
	public virtual DbSet<WorkingTime> WorkingTimes {get; set;}
	}
}
