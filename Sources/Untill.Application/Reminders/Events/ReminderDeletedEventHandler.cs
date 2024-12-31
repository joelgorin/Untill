using MediatR;

using Untill.Application.Common.Interfaces;
using Untill.Domain.Users.Events;

namespace Untill.Application.Reminders.Events;

public class ReminderDeletedEventHandler(IRemindersRepository _remindersRepository) : INotificationHandler<ReminderDeletedEvent>
{
    public async Task Handle(ReminderDeletedEvent notification, CancellationToken cancellationToken)
    {
        var reminder = await _remindersRepository.GetByIdAsync(notification.ReminderId, cancellationToken)
            ?? throw new InvalidOperationException();

        await _remindersRepository.RemoveAsync(reminder, cancellationToken);
    }
}
