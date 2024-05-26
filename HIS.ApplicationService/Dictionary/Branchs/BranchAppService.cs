using HIS.Core.Domain.Repositories;
using HIS.Dtos.Dictionaries.Branchs;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities;
using HIS.ApplicationService.Dictionary.Branchs.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.EntityFrameworkCore.Entities.System;

namespace HIS.ApplicationService.Dictionary.Branchs
{
    public class BranchAppService : BaseAppService, IBranchAppService
    {
        private readonly IRepository<Branch, Guid> _branchRepository;
        private readonly IRepository<HospitalLevel, Guid> _hospitalLevelRepository;
        private readonly IRepository<HospitalLine, Guid> _hospitalLineRepository;
        private readonly IRepository<HospitalSpeciality, Guid> _hospitalSpecialityRepository;
        private readonly IRepository<Province, Guid> _provinceRepository;
        private readonly IRepository<District, Guid> _districtRepository;
        private readonly IRepository<Ward, Guid> _wardRepository;
        private readonly IRepository<User, Guid> _userRepository;

        public BranchAppService(
            IRepository<Branch, Guid> branchRepository,
            IRepository<HospitalLevel, Guid> hospitalLevelRepository,
            IRepository<HospitalLine, Guid> hospitalLineRepository,
            IRepository<HospitalSpeciality, Guid> hospitalSpecialityRepository,
            IRepository<Province, Guid> provinceRepository,
            IRepository<District, Guid> districtRepository,
            IRepository<Ward, Guid> wardRepository,
            IRepository<User, Guid> userRepository)
        {
            _branchRepository = branchRepository;
            _hospitalLevelRepository = hospitalLevelRepository;
            _hospitalLineRepository = hospitalLineRepository;
            _hospitalSpecialityRepository = hospitalSpecialityRepository;
            _provinceRepository = provinceRepository;
            _districtRepository = districtRepository;
            _wardRepository = wardRepository;
            _userRepository = userRepository;
        }

        public virtual async Task<PagedResultDto<BranchDto>> GetAll(GetAllBranchInputDto input)
        {
            var result = new PagedResultDto<BranchDto>();
            try
            {
                var branchFilter = _branchRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.BranchCodeFilter), x => x.BranchCode == input.BranchCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.BranchNameFilter), x => x.BranchName == input.BranchNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var filter = from o in branchFilter

                             join o1 in _hospitalLevelRepository.GetAll() on o.HospitalLevelID equals o1.Id into j1
                             from s1 in j1.DefaultIfEmpty()

                             join o2 in _hospitalLineRepository.GetAll() on o.HospitalLineID equals o2.Id into j2
                             from s2 in j2.DefaultIfEmpty()

                             join o3 in _hospitalSpecialityRepository.GetAll() on o.HospitalSpecialityID equals o3.Id into j3
                             from s3 in j3.DefaultIfEmpty()

                             join o4 in _provinceRepository.GetAll() on o.ProvinceID equals o4.Id into j4
                             from s4 in j4.DefaultIfEmpty()

                             join o5 in _districtRepository.GetAll() on o.DistrictID equals o5.Id into j5
                             from s5 in j5.DefaultIfEmpty()

                             join o6 in _wardRepository.GetAll() on o.WardID equals o6.Id into j6
                             from s6 in j6.DefaultIfEmpty()

                             join o7 in _userRepository.GetAll() on o.DirectorID equals o7.Id into j7
                             from s7 in j7.DefaultIfEmpty()

                             select new BranchDto()
                             {
                                 Id = o.Id,
                                 BranchCode = o.BranchCode,
                                 BranchName = o.BranchName,
                                 MediOrgCode = o.MediOrgCode,
                                 MediOrgAcceptCode = o.MediOrgAcceptCode,
                                 HospitalLevelID = o.HospitalLevelID,
                                 HospitalLevelName = s1.HospitalLevelName,
                                 HospitalLevelCode = s1.HospitalLevelCode,
                                 HospitalLineID = o.HospitalLineID,
                                 HospitalLineName = s2.HospitalLineName,
                                 HospitalLineCode = s2.HospitalLineCode,
                                 HospitalSpecialityID = o.HospitalSpecialityID,
                                 HospitalSpecialityName = s3.HospitalSpecialityName,
                                 HospitalSpecialityCode = s3.HospitalSpecialityCode,
                                 ParentOrganizationName = o.ParentOrganizationName,
                                 PhoneNumber = o.PhoneNumber,
                                 Email = o.Email,
                                 Address = o.Address,
                                 ProvinceID = o.ProvinceID,
                                 ProvinceName = s4.Name,
                                 ProvinceCode = s4.Code,
                                 DistrictID = o.DistrictID,
                                 DistrictName = s5.Name,
                                 DistrictCode = s5.Code,
                                 WardID = o.WardID,
                                 WardName = s6.Name,
                                 WardCode = s6.Code,
                                 DirectorID = o.DirectorID,
                                 DirectorName = s7.FullName,
                                 Description = o.Description,
                                 SortOrder = o.SortOrder,
                                 Inactive = o.Inactive
                             };

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<BranchDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> Get(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            try
            {
                var entity = await _branchRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<BranchDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> CreateOrEdit(BranchDto input)
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

        public virtual async Task<ResultDto<BranchDto>> Create(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = ObjectMapper.Map<Branch>(input);

                    await _branchRepository.InsertAsync(branch);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> Update(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _branchRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> Delete(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var branch = _branchRepository.Get(id);

                    await _branchRepository.DeleteAsync(branch);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }
    }
}
