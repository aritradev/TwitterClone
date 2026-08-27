namespace TwitterClone.Domain.Entities;

public class Message:BaseEntities
{
    
    private Guid _senderId;
    private Guid _receiverId;
    private string _content;
    private bool _isRead;
    private DateTime _seenAt;
    

    public Message() : base(Guid.NewGuid())
    {
        
    }
   
    public Guid  SenderId { get; set; }
    public Guid  ReceiverId { get; set; }
    public string  Content { get; set; }

    public bool IsRead
    {
        get { return _isRead; }
        set
        {
            _isRead = value;
            _seenAt = DateTime.UtcNow;
        }
    }

    public DateTime SeenAt { get; set; }


    public override string DescribeRecord()
    {
        
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, SeenAt: {SeenAt}, IsRead: {IsRead}";
    }
}