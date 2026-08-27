namespace TwitterClone.Domain.Entities;

public class Follow
{
    private Guid _id;
    private Guid _followerId;
    private Guid _followingId;
    private DateTime _createdAt;
    
    public Follow()
    {
        _id=Guid.NewGuid();
        _createdAt=DateTime.UtcNow;    
    }
    public Guid Id { get; }
    public Guid FollowerId { get; set; }
    public Guid FollowingId { get; set; }
    public DateTime CreatedAt { get; }
}