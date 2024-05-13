using HIS.Dtos.Dictionaries.Machines;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Core.Application.Services;
using HIS.Core.Extensions;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.Machines
{
    public class MachineService : BaseAppService, IMachineService
    {
        private readonly IRepository<Machine, Guid> _machineRepository;

        public MachineService(IRepository<Machine, Guid> machineRepository)
        {
            _machineRepository = machineRepository;
        }

        public virtual async Task<ResultDto<MachineDto>> CreateOrEdit(MachineDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<MachineDto>> Create(MachineDto input)
        {
            var result = new ResultDto<MachineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new Machine()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,
                        MachineType = input.MachineType,
                        MachineOrderType = input.MachineOrderType,
                        RoomId = input.RoomId,
                        DepartmentId = input.DepartmentId,
                        CreationDate = input.CreationDate,
                        Creator = input.Creator,
                        UsageStandard = input.UsageStandard,
                    };
                    await _machineRepository.InsertAsync(data);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<MachineDto>> Update(MachineDto input)
        {
            var result = new ResultDto<MachineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var data = new Machine()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,                        
                        MachineType = input.MachineType,
                        MachineOrderType = input.MachineOrderType,
                        RoomId = input.RoomId,
                        DepartmentId = input.DepartmentId,
                        CreationDate = input.CreationDate,
                        Creator = input.Creator,
                        UsageStandard = input.UsageStandard,
                    };

                    await _machineRepository.UpdateAsync(data);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<MachineDto>> Delete(Guid id)
        {
            var result = new ResultDto<MachineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _machineRepository.Get(id);

                    await _machineRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<PagedResultDto<MachineDto>> GetAll(GetAllMachineInput input)
        {
            var result = new PagedResultDto<MachineDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in _machineRepository.GetAll()
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new MachineDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     MachineType = r.MachineType,
                                     MachineOrderType = r.MachineOrderType,
                                     RoomId = r.RoomId,
                                     DepartmentId = r.DepartmentId,
                                     CreationDate = r.CreationDate,
                                     Creator = r.Creator,
                                     UsageStandard = r.UsageStandard,
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<MachineDto>> GetById(Guid id)
        {
            var result = new ResultDto<MachineDto>();

            var machine = _machineRepository.FirstOrDefault(s => s.Id == id);
            if (machine != null)
            {
                result.IsSucceeded = true;
                result.Result = new MachineDto()
                {
                    Id = machine.Id,
                    Code = machine.Code,
                    Name = machine.Name,
                    Description = machine.Description,
                    Inactive = machine.Inactive,
                    MachineType = machine.MachineType,
                    MachineOrderType = machine.MachineOrderType,
                    RoomId = machine.RoomId,
                    DepartmentId = machine.DepartmentId,
                    CreationDate = machine.CreationDate,
                    Creator = machine.Creator,
                    UsageStandard = machine.UsageStandard,
                };
            }

            return await Task.FromResult(result);
        }
    }
}
