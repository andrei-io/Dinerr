using Dinerr.Application.Common.Interfaces.Services;

namespace Dinerr.Infrastructure.Services;

public class DateTimeProvider: IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}