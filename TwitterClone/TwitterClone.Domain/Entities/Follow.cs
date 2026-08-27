namespace TwitterClone.Domain.Entities;

public class Follow:BaseEntities
{
    
    private Guid _followerId;
    private Guid _followingId;

    public Follow() : base(Guid.NewGuid())
    {
        
    }
    
    public Guid FollowerId { get; set; }
    public Guid FollowingId { get; set; }
   
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, FollowerId:{FollowerId}, FollowingId:{FollowingId}";
    }
}