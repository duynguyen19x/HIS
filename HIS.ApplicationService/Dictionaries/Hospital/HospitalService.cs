using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Hospital
{
    public class HospitalService : BaseCrudAppService<HospitalDto, Guid?, GetAllHospitalInput>, IHospitalService
    {
        public HospitalService(HISDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<HospitalDto>> Create(HospitalDto input)
        {
            var result = new ResultDto<HospitalDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Hospital()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,
                        Address = input.Address,
                        Grade = input.Grade,
                        Line = input.Line,
                        CreatedDate = DateTime.Now
                    };
                    Context.Hospitals.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<HospitalDto>> Update(HospitalDto input)
        {
            var result = new ResultDto<HospitalDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Hospital()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,
                        Address = input.Address,
                        Grade = input.Grade,
                        Line = input.Line,
                        MohCode = input.MohCode,
                        ModifiedDate = DateTime.Now
                    };
                    Context.Hospitals.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<HospitalDto>> Delete(Guid? id)
        {
            var result = new ResultDto<HospitalDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.Hospitals.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.Hospitals.Remove(data);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<HospitalDto>> GetAll(GetAllHospitalInput input)
        {
            var result = new PagedResultDto<HospitalDto>();
            try
            {
                result.IsSucceeded = true;
                result.Items = (from r in Context.Hospitals
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new HospitalDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     Address = r.Address,
                                     MohCode = r.MohCode,
                                     Grade = r.Grade,
                                     Line = r.Line
                                 }).ToList();
                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<HospitalDto>> GetById(Guid? id)
        {
            var result = new ResultDto<HospitalDto>();

            var hospital = Context.Hospitals.SingleOrDefault(s => s.Id == id);
            if (hospital != null)
            {
                result.IsSucceeded = true;
                result.Item = new HospitalDto()
                {
                    Id = hospital.Id,
                    Code = hospital.Code,
                    Name = hospital.Name,
                    Description = hospital.Description,
                    Inactive = hospital.Inactive,
                    MohCode= hospital.MohCode,
                    Grade = hospital.Grade,
                    Line = hospital.Line,
                    Address = hospital.Address
                };
            }

            return await Task.FromResult(result);
        }
    }
}
