using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceResultData : Entity<Guid>
    {
        public Guid? ServiceResultIndiceId { get; set; }

        public Guid? ServiceRequestDataId { get; set; }

        public Guid? ServiceId { get; set; }

        public string Result { get; set; }

        public ServiceResultDataType ResultType { get; set; }

        [Ignore]
        public Service Service { get; set; }

        [Ignore]
        public ServiceRequestData ServiceRequestData { get; set; }

        [Ignore]
        public ServiceResultIndice ServiceResultIndice { get; set; }
    }
}
