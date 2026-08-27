namespace TwitterClone.Domain.Entities;

public class Retweet:BaseEntities
{
    
    
    private Guid _tweetId;
    private string _content;
    private string _reacts;
    private string _comment;
    private string _retweets;
   

    public Retweet() : base(Guid.NewGuid())
    {

    }
    public Guid TweetId { get; set; }
    public string Content { get; set; }
    public string Reacts { get; set; }
    public string Comment { get; set; }
    public string Retweets { get; set; }

    public override string DescribeRecord()
    {
        var baseRecord= base.DescribeRecord();
        return $"BaseRecord:{baseRecord},TweetId:{TweetId}, Content:{Content},Reacts:{Reacts},Comment:{Comment},Retweets:{Retweets}";
    }
}