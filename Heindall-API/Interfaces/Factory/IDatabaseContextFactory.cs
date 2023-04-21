using Heindall_API.Context;
using Microsoft.EntityFrameworkCore;

namespace Heindall_API.Interfaces.Factory;

public interface IDatabaseContextFactory
{
    RexturContext CreateRexturContext(string connectionString);
}
