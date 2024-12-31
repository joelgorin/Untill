using ErrorOr;

using Untill.Application.Common.Security.Request;
using Untill.Application.Common.Security.Roles;

namespace Untill.Application.Subscriptions.Commands.CancelSubscription;

[Authorize(Roles = Role.Admin)]
public record CancelSubscriptionCommand(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<Success>>;