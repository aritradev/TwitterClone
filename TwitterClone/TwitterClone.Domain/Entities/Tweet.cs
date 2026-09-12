namespace TwitterClone.Domain.Entities;

public class Tweet:BaseEntities,ILikeable
{
    private Guid _userId;
    private string _content;
    private string _reacts;
    private string _comment;
    private string _retweet;

    public const int MaxContentLength = 200;
    //const & static same kaj kore - hard code na kore ekta class e sob define kora.

    public Tweet(string content):base(Guid.NewGuid())
    {
        _content = content;
    }

    public Guid UserId { get; set; }
    public string Content { get; set; }
    public string Reacts { get; set; }
    public string Comment { get; set; }

    public void AddContent(string content)
    {
        _content = content;
    }

    public void AddContent(Guid userId, string content)
    {
        _userId= userId;
        _content = content;
    }
    public override string DescribeRecord()
    {
        var baseRecord=  base.DescribeRecord();
        return $"BaseReord:{baseRecord},Content:{_content},Reacts:{_reacts},Comment:{_comment},Retweets:{_retweet}";
    }

    public bool CanBeLiked()
    {
        if(string.IsNullOrWhiteSpace(Content))
        {
            return false;
        }
        return true;
    }
    
}