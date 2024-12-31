using Untill.Domain.Common;
using Untill.Domain.Reminders;

namespace Untill.Domain.Users.Events;

public record ReminderSetEvent(Reminder Reminder) : IDomainEvent;