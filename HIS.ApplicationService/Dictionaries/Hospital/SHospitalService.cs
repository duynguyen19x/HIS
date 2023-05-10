using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Hospital;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Hospital
{
    public class SHospitalService : BaseSerivce, ISHospitalService
    {
        public SHospitalService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SHospitalDto>> CreateOrEdit(SHospitalDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SHospitalDto>> Create(SHospitalDto input)
        {
            var result = new ApiResult<SHospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new SHospital()
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
                    _dbContext.SHospitals.Add(data);
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

        public async Task<ApiResult<SHospitalDto>> Update(SHospitalDto input)
        {
            var result = new ApiResult<SHospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = new SHospital()
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
                    _dbContext.SHospitals.Update(data);
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

        public async Task<ApiResult<SHospitalDto>> Delete(Guid id)
        {
            var result = new ApiResult<SHospitalDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.SHospitals.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.SHospitals.Remove(data);
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

        public async Task<ApiResultList<SHospitalDto>> GetAll(GetAllSHospitalInput input)
        {
            var result = new ApiResultList<SHospitalDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SHospitals
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SHospitalDto()
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

        public async Task<ApiResult<SHospitalDto>> GetById(Guid id)
        {
            var result = new ApiResult<SHospitalDto>();

            var hospital = _dbContext.SHospitals.SingleOrDefault(s => s.Id == id);
            if (hospital != null)
            {
                result.IsSuccessed = true;
                result.Result = new SHospitalDto()
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
