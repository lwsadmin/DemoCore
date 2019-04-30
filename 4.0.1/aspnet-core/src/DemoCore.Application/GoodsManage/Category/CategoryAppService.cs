using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Notifications;
using Abp.Runtime.Session;
using Abp.UI;
using DemoCore.GoodsManage.Category.Dto;
using DemoCore.GoodsManage.Dto;
using model = DemoCore.GoodsManager;
 
namespace DemoCore.GoodsManage.Category
{
    public class CategoryAppService : ApplicationService, ICategoryAppService
    {
        private readonly IRealTimeNotifier _not;
        private readonly IRepository<model.Category, long> _Repository;
        public readonly IAbpSession _AbpSession;
        public CategoryAppService(IRepository<model.Category, long> repository, IAbpSession AbpSession, IRealTimeNotifier not)
        {
            _Repository = repository;
            _AbpSession = AbpSession;
            _not = not;
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

        public async Task<MemoryStream> Export()
        {
            //FileStream fs = new FileStream("C:\\Users\\jm\\Desktop\\委托和事件\\1.txt", FileMode.OpenOrCreate, FileAccess.Read);

            UserNotification not = new UserNotification();
            not.Id = Guid.NewGuid();
            not.TenantId = 1;
            not.State = UserNotificationState.Unread;
            //not.Notification
            TenantNotification tenNot = new TenantNotification();
            tenNot.TenantId = 1;
            tenNot.Id = Guid.NewGuid();
            tenNot.NotificationName = "export";
            Dictionary<string, object> s = new Dictionary<string, object>();
            s.Add("message", "我的通知");
            tenNot.Data = new NotificationData() { Properties = s };
            UserNotification[] notArray = { not };
            _not.SendNotificationsAsync(notArray);

            byte[] buff = File.ReadAllBytes("C:\\Users\\jm\\Desktop\\委托和事件\\1.txt");
            MemoryStream ms = new MemoryStream(buff);
            return ms;
        }
    }
}
