using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using DemoCore.GoodsManage.Dto;
namespace DemoCore.GoodsManage.Category.Dto
{
    public interface ICategoryAppService : IApplicationService
    {
       Task<List<CategoryListDto>> GetAllListAsync();
        Task CreateOrEditAsync(CategoryEditDto dto);
        Task DeleteAsync(long id);

        Task<MemoryStream> Export();
    }
}
