using ErrorOr;

using Untill.Application.Common.Security.Permissions;
using Untill.Application.Common.Security.Policies;
using Untill.Application.Common.Security.Request;
using Untill.Domain.Reminders;

namespace Untill.Application.Reminders.Queries.GetReminder;

[Authorize(Permissions = Permission.Reminder.Get, Policies = Policy.SelfOrAdmin)]
public record GetReminderQuery(Guid UserId, Guid SubscriptionId, Guid ReminderId) : IAuthorizeableRequest<ErrorOr<Reminder>>;