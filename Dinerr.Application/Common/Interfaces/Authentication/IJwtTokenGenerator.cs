using Dinerr.Domain.Entitities;

namespace Dinerr.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}