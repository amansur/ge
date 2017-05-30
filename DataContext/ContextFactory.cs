using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace georgia
{
	public class ContextFactory : IDbContextFactory<Context>
	{
		public Context Create(DbContextFactoryOptions options)
		{
			var optionsBuilder = new DbContextOptionsBuilder<Context>();
			optionsBuilder.UseSqlite("Data Source=georgia.db");

			return new Context(optionsBuilder.Options);
		}
	}
}