namespace TwitterClone.Domain.Entities;

public class BaseEntities
{
  public Guid Id { get; private set; }
  public Guid UserId { get; private set; }
  public DateTime CreatedAt { get; private set; }
  public DateTime? UpdatedAt { get; private set; }
  public Guid CreatedBy { get; private set; }
  public Guid? UpdatedBy { get; private set; }

  public BaseEntities(Guid id)
  {
    Id = id;
    CreatedAt = DateTime.UtcNow;
  }

  public virtual string DescribeRecord()
  {
    return $"BaseEntities Id:{Id},UserId:{UserId},CreatedAt:{CreatedAt}, UpdatedAt:{UpdatedAt},CreatedBy:{CreatedBy}, UpdatedBy:{UpdatedBy}";
  }
  
}