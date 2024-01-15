namespace HIS.Core.Entities.Auditing
{
    public interface ICreationAudited
    {
        DateTime? CreatedDate { get; set; }
        Guid? CreatedBy { get; set; }
    }
}
