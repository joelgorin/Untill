using ErrorOr;

using Untill.Application.Common.Security.Permissions;
using Untill.Application.Common.Security.Policies;
using Untill.Application.Common.Security.Request;
using Untill.Domain.Reminders;

namespace Untill.Application.Reminders.Queries.ListReminders;

[Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
public record ListRemindersQuery(Guid UserId, Guid SubscriptionId) : IAuthorizeableRequest<ErrorOr<List<Reminder>>>;