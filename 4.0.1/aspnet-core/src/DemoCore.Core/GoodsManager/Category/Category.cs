using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCore.GoodsManager
{
    [Table("TGoodsCategory")]
    public class Category : Entity<long>, IMustHaveTenant, IHasCreationTime
    {
        public int TenantId { get; set; }

        [Required(ErrorMessage = "请输入类别名称!")]
        [MaxLength(20, ErrorMessage = "最多只能包含20个字符!")]
        public string Title { get; set; }

        [MaxLength(200, ErrorMessage = "备注信息最多不能超出200个字符!")]
        public string Memo { get; set; }

        public DateTime CreationTime
        {
            get { return Clock.Now; }
            set { }
        }

    }
}
