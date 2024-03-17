using HIS.EntityFrameworkCore;
using HIS.Application.Core.Services;
using AutoMapper;
using HIS.ApplicationService.Dictionaries.Machines;
using HIS.Dtos.Dictionaries.Machines;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.Machines
{
    public class MachineService : BaseCrudAppService<MachineDto, Guid?, GetAllMachineInput>, IMachineService
    {
        public MachineService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {

        }

        public override async Task<ResultDto<MachineDto>> Create(MachineDto input)
        {
            var result = new ResultDto<MachineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Machine()
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
                    Context.Machines.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

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

        public override async Task<ResultDto<MachineDto>> Update(MachineDto input)
        {
            var result = new ResultDto<MachineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Machine()
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
                    Context.Machines.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

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

        public override async Task<ResultDto<MachineDto>> Delete(Guid? id)
        {
            var result = new ResultDto<MachineDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var machine = Context.Machines.SingleOrDefault(x => x.Id == id);
                    if (machine != null)
                    {
                        Context.Machines.Remove(machine);
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

        public override async Task<PagedResultDto<MachineDto>> GetAll(GetAllMachineInput input)
        {
            var result = new PagedResultDto<MachineDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Machines
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

        public override async Task<ResultDto<MachineDto>> GetById(Guid? id)
        {
            var result = new ResultDto<MachineDto>();

            var machine = Context.Machines.SingleOrDefault(s => s.Id == id);
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
