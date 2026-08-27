namespace TwitterClone.Domain.Entities;

public class Tweet:BaseEntities
{
 
    private string _content;
    private string _reacts;
    private string _comment;
    private string _retweet;
    

    public Tweet():base(Guid.NewGuid())
    {
        
    }
    
    public string Content { get; set; }
    public string Reacts { get; set; }
    public string Comment { get; set; }

    public override string DescribeRecord()
    {
        var baseRecord=  base.DescribeRecord();
        return $"BaseReord:{baseRecord},Content:{_content},Reacts:{_reacts},Comment:{_comment},Retweets:{_retweet}";
    }
}