using Untill.Domain.Common;

namespace Untill.Domain.Users.Events;

public record ReminderDeletedEvent(Guid ReminderId) : IDomainEvent;