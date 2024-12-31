using ErrorOr;

using Untill.Application.Common.Security.Permissions;
using Untill.Application.Common.Security.Policies;
using Untill.Application.Common.Security.Request;

namespace Untill.Application.Reminders.Commands.DeleteReminder;

[Authorize(Permissions = Permission.Reminder.Delete, Policies = Policy.SelfOrAdmin)]
public record DeleteReminderCommand(Guid UserId, Guid SubscriptionId, Guid ReminderId)
    : IAuthorizeableRequest<ErrorOr<Success>>;