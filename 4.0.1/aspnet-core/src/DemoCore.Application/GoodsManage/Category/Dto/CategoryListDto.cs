using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using model = DemoCore.GoodsManager;

namespace DemoCore.GoodsManage.Dto
{
    [AutoMapFrom(typeof(model.Category))]
    public class CategoryListDto : EntityDto
    {
        public int TenantId { get; set; }

        public string Title { get; set; }

        public string Memo { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
