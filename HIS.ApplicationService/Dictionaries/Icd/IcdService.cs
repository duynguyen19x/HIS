﻿using HIS.ApplicationService.Dictionaries.Career;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.Career;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Icd
{
    public class IcdService : BaseSerivce, IIcdService
    {
        public IcdService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<IcdDto>> CreateOrEdit(IcdDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<IcdDto>> Create(IcdDto input)
        {
            var result = new ApiResult<IcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Icd()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,
                        ChapterCode = input.ChapterCode,
                        ChapterName = input.ChapterName,
                        ChapterNameEnglish = input.ChapterNameEnglish,
                        MainGroupCode = input.MainGroupCode,
                        MainGroupName = input.MainGroupName,
                        MainGroupNameEnglish = input.MainGroupNameEnglish,
                        MohReportCode = input.MohReportCode,
                        NameCommon = input.NameCommon,
                        NameEnglish = input.NameEnglish,
                        SubGroup1Code = input.SubGroup1Code,
                        SubGroup1Name = input.SubGroup1Name,
                        SubGroup1NameEnglish = input.SubGroup1NameEnglish,
                        SubGroup2Code = input.SubGroup2Code,
                        SubGroup2Name = input.SubGroup2Name,
                        SubGroup2NameEnglish = input.SubGroup2NameEnglish,
                        TypeCode = input.TypeCode,
                        TypeName = input.TypeName,
                        TypeNameEnglish = input.TypeNameEnglish,
                    };
                    _dbContext.Icds.Add(data);
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

        public async Task<ApiResult<IcdDto>> Update(IcdDto input)
        {
            var result = new ApiResult<IcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = new EntityFrameworkCore.Entities.Dictionaries.Icd()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive,
                        ChapterCode = input.ChapterCode,
                        ChapterName = input.ChapterName,
                        ChapterNameEnglish = input.ChapterNameEnglish,
                        MainGroupCode = input.MainGroupCode,
                        MainGroupName = input.MainGroupName,
                        MainGroupNameEnglish = input.MainGroupNameEnglish,
                        MohReportCode = input.MohReportCode,
                        NameCommon = input.NameCommon,
                        NameEnglish = input.NameEnglish,
                        SubGroup1Code = input.SubGroup1Code,
                        SubGroup1Name = input.SubGroup1Name,
                        SubGroup1NameEnglish = input.SubGroup1NameEnglish,
                        SubGroup2Code = input.SubGroup2Code,
                        SubGroup2Name = input.SubGroup2Name,
                        SubGroup2NameEnglish = input.SubGroup2NameEnglish,
                        TypeCode = input.TypeCode,
                        TypeName = input.TypeName,
                        TypeNameEnglish = input.TypeNameEnglish,
                    };
                    _dbContext.Icds.Update(data);
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

        public async Task<ApiResult<IcdDto>> Delete(Guid id)
        {
            var result = new ApiResult<IcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var icd = _dbContext.Icds.SingleOrDefault(x => x.Id == id);
                    if (icd != null)
                    {
                        _dbContext.Icds.Remove(icd);
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

        public async Task<ApiResultList<IcdDto>> GetAll(GetAllIcdInput input)
        {
            var result = new ApiResultList<IcdDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Icds
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new IcdDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     ChapterCode = r.ChapterCode,
                                     ChapterName = r.ChapterName,
                                     ChapterNameEnglish = r.ChapterNameEnglish,
                                     MainGroupCode = r.MainGroupCode,
                                     MainGroupName = r.MainGroupName,
                                     MainGroupNameEnglish = r.MainGroupNameEnglish,
                                     MohReportCode = r.MohReportCode,
                                     NameCommon = r.NameCommon,
                                     NameEnglish = r.NameEnglish,
                                     SubGroup1Code = r.SubGroup1Code,
                                     SubGroup1Name = r.SubGroup1Name,
                                     SubGroup1NameEnglish = r.SubGroup1NameEnglish,
                                     SubGroup2Code = r.SubGroup2Code,
                                     SubGroup2Name = r.SubGroup2Name,
                                     SubGroup2NameEnglish = r.SubGroup2NameEnglish,
                                     TypeCode = r.TypeCode,
                                     TypeName = r.TypeName,
                                     TypeNameEnglish = r.TypeNameEnglish
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<IcdDto>> GetById(Guid id)
        {
            var result = new ApiResult<IcdDto>();

            var icd = _dbContext.Icds.SingleOrDefault(s => s.Id == id);
            if (icd != null)
            {
                result.IsSuccessed = true;
                result.Result = new IcdDto()
                {
                    Id = icd.Id,
                    Code = icd.Code,
                    Name = icd.Name,
                    Description = icd.Description,
                    Inactive = icd.Inactive,
                    ChapterCode = icd.ChapterCode,
                    ChapterName = icd.ChapterName,
                    ChapterNameEnglish = icd.ChapterNameEnglish,
                    MainGroupCode = icd.MainGroupCode,
                    MainGroupName = icd.MainGroupName,
                    MainGroupNameEnglish = icd.MainGroupNameEnglish,
                    MohReportCode = icd.MohReportCode,
                    NameCommon = icd.NameCommon,
                    NameEnglish = icd.NameEnglish,
                    SubGroup1Code = icd.SubGroup1Code,
                    SubGroup1Name = icd.SubGroup1Name,
                    SubGroup1NameEnglish = icd.SubGroup1NameEnglish,
                    SubGroup2Code = icd.SubGroup2Code,
                    SubGroup2Name = icd.SubGroup2Name,
                    SubGroup2NameEnglish = icd.SubGroup2NameEnglish,
                    TypeCode = icd.TypeCode,
                    TypeName = icd.TypeName,
                    TypeNameEnglish = icd.TypeNameEnglish
                };
            }

            return await Task.FromResult(result);
        }
    }
}
