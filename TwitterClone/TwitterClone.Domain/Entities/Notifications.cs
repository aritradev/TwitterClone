namespace TwitterClone.Domain.Entities;

public class Notifications:BaseEntities
{
      private string _type;
    private string _message;
    private bool _isRead;
  
    public Notifications():base(Guid.NewGuid())
    {
       
    }
    public string Type { get; set; }
    public string Message { get; set; }
    public bool  IsRead { get; }
   
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"baseRecord:{baseRecord}, Type:{_type},Message:{_message},IsRead:{_isRead}";
    }
}