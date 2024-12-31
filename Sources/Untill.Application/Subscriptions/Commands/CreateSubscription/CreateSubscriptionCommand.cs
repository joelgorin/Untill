using ErrorOr;

using Untill.Application.Common.Security.Permissions;
using Untill.Application.Common.Security.Policies;
using Untill.Application.Common.Security.Request;
using Untill.Application.Subscriptions.Common;
using Untill.Domain.Users;

namespace Untill.Application.Subscriptions.Commands.CreateSubscription;

[Authorize(Permissions = Permission.Subscription.Create, Policies = Policy.SelfOrAdmin)]
public record CreateSubscriptionCommand(
    Guid UserId,
    string FirstName,
    string LastName,
    string Email,
    SubscriptionType SubscriptionType)
    : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;