using TestCommon.TestConstants;

using Untill.Application.Subscriptions.Commands.CancelSubscription;
using Untill.Application.Subscriptions.Commands.CreateSubscription;
using Untill.Domain.Users;

namespace TestCommon.Subscriptions;

public static class SubscriptionCommandFactory
{
    public static CreateSubscriptionCommand CreateCreateSubscriptionCommand(
        Guid? userId = null,
        string firstName = Constants.User.FirstName,
        string lastName = Constants.User.LastName,
        string email = Constants.User.Email,
        SubscriptionType? subscriptionType = null)
    {
        return new CreateSubscriptionCommand(
            userId ?? Constants.User.Id,
            firstName,
            lastName,
            email,
            subscriptionType ?? Constants.Subscription.Type);
    }

    public static CancelSubscriptionCommand CreateCancelSubscriptionCommand(
        Guid? userId = null,
        Guid? subscriptionId = null)
    {
        return new CancelSubscriptionCommand(
            userId ?? Constants.User.Id,
            subscriptionId ?? Constants.Subscription.Id);
    }
}