namespace TwitterClone.Domain.Entities;

public class SystemNotification:Notifications 
{
    public SystemNotification(Guid systemUserId) : base("System")
    {
        SystemId = systemUserId;
    }
    public Guid SystemId { get; set; }

    public void AddMessage(string message)
    {
        Message = message;
        IsRead = true;
    }

    public override string DescribeRecord()
    {
        var baseRecord= base.DescribeRecord();
        return $"BaseRecord:{baseRecord},SystemrId:{SystemId} ,Message:{Message}";
    }

    public override string GetMessage()
    {
        return $"System Notification: Unknown Error";
    }
}