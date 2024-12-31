using FluentValidation;

using Untill.Application.Common.Interfaces;

namespace Untill.Application.Reminders.Commands.SetReminder;

public class SetReminderCommandValidator : AbstractValidator<SetReminderCommand>
{
    public SetReminderCommandValidator(IDateTimeProvider dateTimeProvider)
    {
        RuleFor(x => x.DateTime).GreaterThan(dateTimeProvider.UtcNow);
        RuleFor(x => x.Text).MinimumLength(3).MaximumLength(10000);
    }
}