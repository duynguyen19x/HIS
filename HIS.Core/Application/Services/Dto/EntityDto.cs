namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class EntityDto : IEntityDto
    {
    }

    [Serializable]
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
