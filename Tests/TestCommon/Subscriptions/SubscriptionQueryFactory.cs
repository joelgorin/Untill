using TestCommon.TestConstants;

using Untill.Application.Subscriptions.Queries.GetSubscription;

namespace TestCommon.Subscriptions;

public static class SubscriptionQueryFactory
{
    public static GetSubscriptionQuery CreateGetSubscriptionQuery(
        Guid? userId = null)
    {
        return new GetSubscriptionQuery(userId ?? Constants.User.Id);
    }
}