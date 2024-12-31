using ErrorOr;

using Untill.Application.Common.Security.Permissions;
using Untill.Application.Common.Security.Policies;
using Untill.Application.Common.Security.Request;
using Untill.Application.Subscriptions.Common;

namespace Untill.Application.Subscriptions.Queries.GetSubscription;

[Authorize(Permissions = Permission.Subscription.Get, Policies = Policy.SelfOrAdmin)]
public record GetSubscriptionQuery(Guid UserId)
    : IAuthorizeableRequest<ErrorOr<SubscriptionResult>>;