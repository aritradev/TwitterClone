namespace TwitterClone.Domain.Entities;

public class User:Bookmarks
{
    
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _password;
    

    public User()
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

    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, FirstName:{_firstName},LastName:{_lastName},Email:{_email},Password:{_password}";
    }
}

