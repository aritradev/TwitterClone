namespace TwitterClone.Domain.Entities;

public class user
{
    private Guid _id;
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _password;
    private DateTime _createdAt;

    public user()
    {
       _id = Guid.NewGuid();
       _createdAt = DateTime.Now;   
    }

    public Guid ID
    {
        get { return _id; }
       
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

    public DateTime Createdat
    {
        get { return _createdAt; }
    }
}

