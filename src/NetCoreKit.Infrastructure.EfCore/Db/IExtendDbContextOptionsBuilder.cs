using Microsoft.EntityFrameworkCore;

namespace NetCoreKit.Infrastructure.EfCore.Db
{
    public interface IExtendDbContextOptionsBuilder
    {
        DbContextOptionsBuilder Extend(
            DbContextOptionsBuilder optionsBuilder,
            IDatabaseConnectionStringFactory connectionStringFactory,
            string assemblyName);
    }
}
