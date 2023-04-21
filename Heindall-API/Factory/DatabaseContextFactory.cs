using Heindall_API.Context;
using Heindall_API.Interfaces.Factory;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Factory;

public class DatabaseContextFactory : IDatabaseContextFactory
{
    public RexturContext CreateRexturContext(string connectionString)
    {
        var optionsBuilder = new DbContextOptionsBuilder<RexturContext>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        return new RexturContext(optionsBuilder.Options);
    }
}

