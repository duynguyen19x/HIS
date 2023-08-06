namespace HIS.Core.Entities.Auditing
{
    public interface IAudited : ICreationAudited
    {
        DateTime? ModifiedDate { get; set; }
        Guid? ModifiedBy { get; set; }
    }
}
