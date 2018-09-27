using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Abp.UI;
using DemoCore.GoodsManage.Category.Dto;
using DemoCore.GoodsManage.Dto;
using model = DemoCore.GoodsManager;
namespace DemoCore.GoodsManage.Category
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {

        private readonly IRepository<model.Category, long> _Repository;
        public readonly IAbpSession _AbpSession;
        public CategoryAppService(IRepository<model.Category, long> repository, IAbpSession AbpSession)
        {
            _Repository = repository;
            _AbpSession = AbpSession;
        }
        public async Task<List<CategoryListDto>> GetAllListAsync()
        {
            var query = await _Repository.GetAllListAsync();

            return query.MapTo<List<CategoryListDto>>();
        }
        public async Task CreateOrEditAsync(CategoryEditDto dto)
        {
            if (_AbpSession.TenantId != null)
                dto.TenantId = (int)_AbpSession.TenantId;
            else
                dto.TenantId = 0;
            throw new UserFriendlyException("ss");
            if (dto.Id > 0)
                await _Repository.UpdateAsync(dto.MapTo<model.Category>());
            else
                await _Repository.InsertAsync(dto.MapTo<model.Category>());

        }
        public async Task DeleteAsync(long id)
        {
            await _Repository.DeleteAsync(id);
            // throw new NotImplementedException();
        }
    }
}
