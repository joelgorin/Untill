using FluentAssertions;

using Untill.Application.Reminders.Commands.SetReminder;
using Untill.Domain.Reminders;

namespace TestCommon.Reminders;

public static class ReminderValidator
{
    public static void AssertCreatedFrom(this Reminder reminder, SetReminderCommand command)
    {
        reminder.SubscriptionId.Should().Be(command.SubscriptionId);
        reminder.DateTime.Should().Be(command.DateTime);
        reminder.Text.Should().Be(command.Text);
        reminder.IsDismissed.Should().BeFalse();
    }
}