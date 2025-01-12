using ErrorOr;

using MediatR;

using Untill.Application.Common.Interfaces;
using Untill.Domain.Reminders;

namespace Untill.Application.Reminders.Queries.GetReminder;

public class GetReminderQueryHandler(IRemindersRepository _remindersRepository)
        : IRequestHandler<GetReminderQuery, ErrorOr<Reminder>>
{
    public async Task<ErrorOr<Reminder>> Handle(GetReminderQuery query, CancellationToken cancellationToken)
    {
        var reminder = await _remindersRepository.GetByIdAsync(query.ReminderId, cancellationToken);

        if (reminder?.UserId != query.UserId)
        {
            return Error.NotFound(description: "Reminder not found");
        }

        return reminder;
    }
}