using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Hospital
{
    public class HospitalService : BaseSerivce, IHospitalService
    {
        public HospitalService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<HospitalDto>> CreateOrEdit(HospitalDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<HospitalDto>> Create(HospitalDto input)
        {
            var result = new ApiResult<HospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
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
                    _dbContext.Hospitals.Add(data);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<HospitalDto>> Update(HospitalDto input)
        {
            var result = new ApiResult<HospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
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
                    _dbContext.Hospitals.Update(data);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<HospitalDto>> Delete(Guid id)
        {
            var result = new ApiResult<HospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.Hospitals.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.Hospitals.Remove(data);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<HospitalDto>> GetAll(GetAllHospitalInput input)
        {
            var result = new ApiResultList<HospitalDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Hospitals
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
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<HospitalDto>> GetById(Guid id)
        {
            var result = new ApiResult<HospitalDto>();

            var hospital = _dbContext.Hospitals.SingleOrDefault(s => s.Id == id);
            if (hospital != null)
            {
                result.IsSuccessed = true;
                result.Result = new HospitalDto()
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
