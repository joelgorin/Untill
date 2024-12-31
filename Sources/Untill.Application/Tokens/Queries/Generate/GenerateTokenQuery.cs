using ErrorOr;

using MediatR;

using Untill.Application.Authentication.Queries.Login;
using Untill.Domain.Users;

namespace Untill.Application.Tokens.Queries.Generate;

public record GenerateTokenQuery(
    Guid? Id,
    string FirstName,
    string LastName,
    string Email,
    SubscriptionType SubscriptionType,
    List<string> Permissions,
    List<string> Roles) : IRequest<ErrorOr<GenerateTokenResult>>;