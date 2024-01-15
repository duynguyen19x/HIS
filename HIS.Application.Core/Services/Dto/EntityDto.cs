namespace HIS.Application.Core.Services.Dto
{
    [Serializable]
    public abstract class EntityDto
    {

    }

    [Serializable]
    public class EntityDto<TPrimaryKey> : EntityDto, IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }

        public EntityDto()
        {
        }

        public EntityDto(TPrimaryKey id)
        {
            Id = id;
        }
    }
}
