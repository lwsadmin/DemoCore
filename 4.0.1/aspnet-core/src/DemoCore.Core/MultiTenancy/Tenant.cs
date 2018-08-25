using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;
using DemoCore.Authorization.Users;

namespace DemoCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {

        }
    }
}
