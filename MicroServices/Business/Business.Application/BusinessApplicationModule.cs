﻿using Volo.Abp.AutoMapper;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using XCZ;

namespace Business
{
    [DependsOn(
        typeof(BusinessApplicationContractsModule),
        typeof(AbpHttpClientIdentityModelModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(FormApplicationModule),
        typeof(AbpAutoMapperModule)
    )]
    public class BusinessApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<BusinessApplicationModule>();
            });
        }
    }
}
