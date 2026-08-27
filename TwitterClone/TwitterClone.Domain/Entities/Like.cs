namespace TwitterClone.Domain.Entities;

public class Like:BaseEntities
{
   
    
    private Guid _tweetId;
   

    public Like():base(Guid.NewGuid())
    {
        
    }

  
    public Guid TweetId { get; set; }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, TweetId:{TweetId}";
    }
}