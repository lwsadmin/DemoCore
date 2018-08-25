using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace DemoCore.GoodsManage.Category.Dto
{
    public class CategoryEditDto: EntityDto
    {

        public string Title { get; set; }

        public string Memo { get; set; }
    }
}
