namespace TwitterClone.Domain.Entities;

public class User:BaseEntities,IFollowable,INotifiable
{
    
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _password;
    

    public User():base(Guid.NewGuid())
    {
        
    }



    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value;  }
    }
    public string Email { get; set; }
    private string PassWord { get; }

    private List<Guid> _followers = new List<Guid>();
    private List<Guid> _inComingNotifications = new List<Guid>();
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, FirstName:{_firstName},LastName:{_lastName},Email:{_email},Password:{_password}";
    }

    public void Follow(Guid userId)
    {
        if (!_followers.Contains(userId))
        {
            _followers.Add(userId);
        }
        
    }

    public void Unfollow(Guid userId)
    {
        if (!_followers.Contains(userId))
        {
            _followers.Remove(userId);
        }
        
    }

    public void AddNotification(Guid notificationId)
    {
        if (!_inComingNotifications.Contains(notificationId))
        {
            _inComingNotifications.Add(notificationId);
        }
        
    }
}

