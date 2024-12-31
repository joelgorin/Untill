using Untill.Domain.Common;

namespace Untill.Domain.Users.Events;

public record ReminderDismissedEvent(Guid ReminderId) : IDomainEvent;