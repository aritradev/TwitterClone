namespace TwitterClone.Domain.Entities;

public class Retweet
{
    private Guid _id;
    private Guid _user;
    private string _content;
    private string _reacts;
    private string _comment;
    private string _retweet;
    private DateTime _createdAt;
    private DateTime _updatedAt;

    public Retweet()
    {
        _createdAt= DateTime.UtcNow;
        _updatedAt= DateTime.UtcNow;
        _id = Guid.NewGuid();
    }
    public Guid Id { get; }
    public Guid UserId { get; set; }
    public string Content { get; set; }
    public string Reacts { get; set; }
    public string Comment { get; set; }
    public DateTime  CreatedAt { get;  }
    public DateTime UpdatedAt { get; set; }
}