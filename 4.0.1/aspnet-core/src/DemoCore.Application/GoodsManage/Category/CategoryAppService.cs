using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using DemoCore.GoodsManage.Category.Dto;
using DemoCore.GoodsManage.Dto;
using model = DemoCore.GoodsManager;
namespace DemoCore.GoodsManage.Category
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {

        private readonly IRepository<model.Category, long> _Repository;

        public CategoryAppService(IRepository<model.Category, long> repository)
        {
            _Repository = repository;
        }
        public async Task<List<CategoryListDto>> GetAllListAsync()
        {
            var query = await _Repository.GetAllListAsync();
            return query.MapTo<List<CategoryListDto>>();
        }
        public async Task CreateOrEditAsync(CategoryEditDto dto)
        {
            if (dto.Id > 0)
            {
                await _Repository.UpdateAsync(dto.MapTo<model.Category>());
            }
            else
            {
                await _Repository.InsertAsync(dto.MapTo<model.Category>());
            }
        }
    }
}
