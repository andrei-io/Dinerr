using Dinerr.Domain.Entitities;

namespace Dinerr.Application.Services.Authentication;

public record AuthenticationResult(
    User user,
    string Token
);