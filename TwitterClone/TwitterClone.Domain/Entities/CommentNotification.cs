namespace TwitterClone.Domain.Entities;

public class CommentNotification:Notifications
{
    public CommentNotification(Guid commentByUserId) : base("comment")
    {
        CommentByUserId = commentByUserId;
    }
    public Guid CommentByUserId { get; set; }

    public void AddMessage(string message)
    {
        Message = message;
    }

    public override string DescribeRecord()
    {
        var baseRecord= base.DescribeRecord();
        return $"BaseRecord:{baseRecord},CommentByUserId:{CommentByUserId} Message:{Message}";
    }
}