namespace TwitterClone.Domain.Entities;

public class Notifications
{
    private Guid _id;
    private Guid _userId;
    private string _type;
    private string _message;
    private bool _isRead;
    private DateTime _createdAt;
    private DateTime _updatedAt;

    public Notifications()
    {
        _createdAt= DateTime.UtcNow;
        _updatedAt= DateTime.UtcNow;
    }
    public Guid Id { get;  }
    public Guid UserId { get; }
    public string Type { get; set; }
    public string Message { get; set; }
    public bool  IsRead { get; }
    public DateTime CreatedAt { get ; }
    public DateTime  UpdatedAt { get ; }
}