namespace TwitterClone.Domain.Entities;

public class Bookmarks : BaseEntities
{
    
    private Guid _tweetId;

    public Bookmarks():base(new Guid())
    {
        
    }
    
    
    public Guid TweetId { get; set; }

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, TweetId:{TweetId}";
    }
    
}