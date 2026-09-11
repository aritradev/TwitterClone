namespace TwitterClone.Domain.Entities;

public abstract class Notifications:BaseEntities
{
    private Guid _userId;
    private string _type;
    private string _message;
    private bool _isRead;
  
    public Notifications(string notificationType):base(Guid.NewGuid())
    {
        _type = notificationType;
    }
    public Guid UserId { get; set; }
    public string Type { get; set; }
    public string Message { get; set; }
    public bool  IsRead { get; set; }
   
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, Type:{_type},Message:{_message},IsRead:{_isRead}";
    }

    public string GetNotificationInfo()
    {
        return $"UserId:{_userId},NotificationType:{_type}";
    }
    public abstract string GetMessage();
}