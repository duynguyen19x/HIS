using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.Utilities.Enums;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class ServiceRequestDetailResult : Entity<Guid>
    {
        public Guid? ServiceResultIndiceId { get; set; }

        public Guid? ServiceRequestDetailId { get; set; }

        public Guid? ServiceRequestId { get; set; }

        public Guid? ServiceId { get; set; }

        public string Result { get; set; }

        public string TestingMachine { get; set; }

        public ServiceResultDataType ResultType { get; set; }

        [Ignore]
        public Service Service { get; set; }

        [Ignore]
        public ServiceRequestDetail ServiceRequestData { get; set; }

        [Ignore]
        public ServiceRequest ServiceRequests { get; set; }

        [Ignore]
        public ServiceResultIndice ServiceResultIndice { get; set; }
    }
}
