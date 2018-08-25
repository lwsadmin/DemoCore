using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
namespace DemoCore.GoodsManager
{
    public class Goods : Entity<long>, IMustHaveTenant, IHasCreationTime
    {
        public int TenantId { get; set; }
        public long CategoryID { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "请输入商品名称!")]
        [MaxLength(50, ErrorMessage = "最多只能包含50个字符!")]
        public string Title { get; set; }


        [Required]
        public string Code { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public decimal MarketPrice { get; set; }

        public GoodsState State { get; set; }


        public int SellCount { get; set; }

        public string Details { get; set; }


        public DateTime CreationTime
        {
            get { return Clock.Now; }
            set { }
        }
    }

    public enum GoodsState
    {
        已上架 = 0,
        已下架 = 1,
        待审核 = -1,
        待补货 = -2
    }
}
