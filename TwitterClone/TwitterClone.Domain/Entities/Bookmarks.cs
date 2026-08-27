namespace TwitterClone.Domain.Entities;

public class Bookmarks
{
    private Guid _id;
    private Guid _userId;
    private Guid _tweetId;
    private DateTime _bookmarkedAt;
    private DateTime _updatedAt;

    public Bookmarks()
    {
        _id = Guid.NewGuid();
        _bookmarkedAt= DateTime.UtcNow;
        _updatedAt= DateTime.UtcNow;
    }
    public Guid Id { get; }
    public Guid UserId { get; set; }
    public Guid TweetId { get; set; }
    public DateTime BookmarkedAt { get; }
    public DateTime UpdatedAt { get; set; }
}