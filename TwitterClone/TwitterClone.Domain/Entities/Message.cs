namespace TwitterClone.Domain.Entities;

public class Message
{
    private Guid _id;
    private string _senderId;
    private string _receiverId;
    private string _content;
    private bool _isRead;
    private DateTime _seenAt;
    private DateTime _createdAt;
    private DateTime _updateddAt;

    public Message()
    {
        _id = Guid.NewGuid();
        _createdAt= DateTime.UtcNow;
        _updateddAt = DateTime.UtcNow;
    }
    public Guid Id { get; }
    public string  SenderId { get; set; }
    public string  ReceiverId { get; set; }
    public string  Content { get; set; }

    public bool Isread
    {
        get { return _isRead; }
        set
        {
            _isRead = value;
            _seenAt = DateTime.UtcNow;
        }
    }
    public DateTime SeenAt
    {
        get { return _seenAt; }
    }
    public  DateTime CreatedAt{ get;  }
    public DateTime UpdatedAt{ get; set; }
}