using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.Supplier;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.Supplier
{
    public class SupplierService : BaseCrudAppService<SupplierDto, Guid?, GetAllSupplierInput>, ISupplierService
    {
        public SupplierService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<SupplierDto>> Create(SupplierDto input)
        {
            var result = new ResultDto<SupplierDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var sSupplier = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Supplier>(input);
                    Context.Suppliers.Add(sSupplier);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<SupplierDto>> Update(SupplierDto input)
        {
            var result = new ResultDto<SupplierDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Supplier>(input);
                    Context.Suppliers.Update(sSupplier);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<SupplierDto>> Delete(Guid? id)
        {
            var result = new ResultDto<SupplierDto>();

            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = Context.Suppliers.SingleOrDefault(x => x.Id == id);
                    if (sSupplier != null)
                    {
                        Context.Suppliers.Remove(sSupplier);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }

            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<SupplierDto>> GetAll(GetAllSupplierInput input)
        {
            var result = new PagedResultDto<SupplierDto>();

            try
            {
                result.Result = (from r in Context.Suppliers
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
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<SupplierDto>> GetById(Guid? id)
        {
            var result = new ResultDto<SupplierDto>();

            try
            {
                var sSuppliers = Context.Suppliers.FirstOrDefault(s => s.Id == id);
                if (sSuppliers != null)
                {
                    result.Result = ObjectMapper.Map<SupplierDto>(sSuppliers);
                }
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
