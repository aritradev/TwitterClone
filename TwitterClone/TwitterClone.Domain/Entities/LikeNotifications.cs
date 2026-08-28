namespace TwitterClone.Domain.Entities;

public class LikeNotifications : Notifications
{
    public LikeNotifications(Guid likeByUserId) : base("Like")
    {
        LikeByUserId = likeByUserId;
    }
    public Guid LikeByUserId { get; set; }
    public void AddMessage(string message)
    {
        Message = message;
    }

    public override string DescribeRecord()
    {
        var baseRecord= base.DescribeRecord();
        return $"BaseRecord:{baseRecord},LikeByUserId:{LikeByUserId}";
    }
}