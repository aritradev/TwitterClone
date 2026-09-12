namespace TweeterClone.Test;
using TwitterClone.Domain.Entities;


public class Class10Test
{
    public void Run()
    {
        IFollowable ifollowable = new User();
        ifollowable.Follow(Guid.NewGuid());
        
        
        Tweet likeableTweet = new Tweet("This is Likeable Tweet");
       likeableTweet.AddContent("I am likeable method");
        Console.WriteLine(likeableTweet.CanBeLiked());

        var maxTweetLength = Tweet.MaxContentLength;
        //object diye statics data access korajai na acess korar jonno class dorkar.
        Console.WriteLine(maxTweetLength);
    }
    
}