using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Supplier;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Supplier
{
    public class SupplierService : BaseSerivce, ISupplierService
    {
        public SupplierService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SupplierDto>> CreateOrEdit(SupplierDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SupplierDto>> Create(SupplierDto input)
        {
            var result = new ApiResult<SupplierDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var sSupplier = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Supplier>(input);
                    _dbContext.Suppliers.Add(sSupplier);
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

        public async Task<ApiResult<SupplierDto>> Update(SupplierDto input)
        {
            var result = new ApiResult<SupplierDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Supplier>(input);
                    _dbContext.Suppliers.Update(sSupplier);
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

        public async Task<ApiResult<SupplierDto>> Delete(Guid id)
        {
            var result = new ApiResult<SupplierDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = _dbContext.Suppliers.SingleOrDefault(x => x.Id == id);
                    if (sSupplier != null)
                    {
                        _dbContext.Suppliers.Remove(sSupplier);
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

        public async Task<ApiResultList<SupplierDto>> GetAll(GetAllSupplierInput input)
        {
            var result = new ApiResultList<SupplierDto>();

            try
            {
                result.Result = (from r in _dbContext.Suppliers
                                 where r.IsDeleted == false
                                 select new SupplierDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Address = r.Address,   
                                     TaxCode = r.TaxCode,
                                     SortOrder = r.SortOrder,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), w => w.Code == input.CodeFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), w => w.Name == input.NameFilter)
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.Code).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SupplierDto>> GetById(Guid id)
        {
            var result = new ApiResult<SupplierDto>();

            try
            {
                var sSuppliers = _dbContext.Suppliers.FirstOrDefault(s => s.Id == id);
                if (sSuppliers != null)
                {
                    result.Result = _mapper.Map<SupplierDto>(sSuppliers);
                }
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
