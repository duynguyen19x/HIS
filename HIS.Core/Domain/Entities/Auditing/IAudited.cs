namespace HIS.Core.Domain.Entities.Auditing
{
    public interface IAudited : ICreationAudited
    {
        DateTime? ModifiedDate { get; set; }
        Guid? ModifiedBy { get; set; }
    }
}
