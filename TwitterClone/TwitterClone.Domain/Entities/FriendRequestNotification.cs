namespace TwitterClone.Domain.Entities;

public class FriendRequestNotifications : Notifications
{
    public FriendRequestNotifications(Guid requestedByUserID) : base("FriendRequest")
    {
        RequestedByUserID = requestedByUserID;

    }
    public Guid  RequestedByUserID { get; set; }

    public void AddMessage(string message)
    {
        Message = message;
    }

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"BaseRecord:{baseRecord},Message:{Message},RequestedByUserID:{RequestedByUserID}";
    }
    public override string GetMessage()
    {
        return $"User with ID {RequestedByUserID} sent you a friend request.";
    }
}