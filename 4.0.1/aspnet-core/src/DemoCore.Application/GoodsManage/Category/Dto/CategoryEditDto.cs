using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Timing;
using model = DemoCore.GoodsManager;
namespace DemoCore.GoodsManage.Category.Dto
{
    [AutoMap(typeof(model.Category))]
    public class CategoryEditDto : EntityDto
    {
        public int TenantId { get; set; }
        public string Title { get; set; }

        public string Memo { get; set; }
    }
}
