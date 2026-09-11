using TwitterClone.Domain.Entities;

namespace TweeterClone.Test;

public class Class9Test
{
    public void Run()
    {
        var notifications = new List<Notifications>()
        {
            new LikeNotifications(Guid.NewGuid()),
            new CommentNotification(Guid.NewGuid()),
            new FriendRequestNotifications(Guid.NewGuid()),
            new MentionNotification(Guid.NewGuid()),
            new SystemNotification(Guid.NewGuid())

        };
        foreach (var notification in notifications)
        {
            Console.Write(notification.GetMessage());
        }
    }
}