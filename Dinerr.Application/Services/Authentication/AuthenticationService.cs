using Dinerr.Application.Common.Interfaces.Authentication;
using Dinerr.Application.Common.Interfaces.Persistence;
using Dinerr.Domain.Entitities;

namespace Dinerr.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _tokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository)
    {
        _tokenGenerator = tokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Validate user doesn't exist
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with that email already exists");
        }

        // Create user
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };
        _userRepository.Add(user);

        // Create JWT token
        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }

    public AuthenticationResult Login(string email, string password)
    {
        // Check that user exists
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User with thar email doesn't exist");
        }


        // TODO: has the password
        // Validate password is correct
        if (user.Password != password)
        {
            throw new Exception("Incorrect password");
        }

        var token = _tokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
}