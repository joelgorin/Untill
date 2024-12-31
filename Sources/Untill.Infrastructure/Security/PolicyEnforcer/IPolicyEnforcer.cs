using ErrorOr;

using Untill.Application.Common.Security.Request;
using Untill.Infrastructure.Security.CurrentUserProvider;

namespace Untill.Infrastructure.Security.PolicyEnforcer;

public interface IPolicyEnforcer
{
    public ErrorOr<Success> Authorize<T>(
        IAuthorizeableRequest<T> request,
        CurrentUser currentUser,
        string policy);
}