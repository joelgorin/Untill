using TestCommon.TestConstants;

using Untill.Domain.Subscriptions;
using Untill.Domain.Users;

namespace TestCommon.Users;

public static class SubscriptionFactory
{
    public static Subscription CreateSubscription(
        SubscriptionType? subscriptionType = null,
        Guid? id = null)
    {
        return new Subscription(
            subscriptionType ?? Constants.Subscription.Type,
            id ?? Constants.Subscription.Id);
    }
}