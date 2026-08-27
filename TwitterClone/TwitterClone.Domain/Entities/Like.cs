namespace TwitterClone.Domain.Entities;

public class Like
{
    private Guid _id;
    private Guid _useId;
    private Guid _tweetId;
    private DateTime _createdAt;

    public Like()
    {
        _createdAt = DateTime.Now;
        _id = Guid.NewGuid();
    }

    public Guid Id
    {
        get { return _id; }
    }
    public Guid UseId { get; set; }
    public Guid TweetId { get; set; }
    public DateTime CreatedAt { get;  }
    
}