using EC.Framework.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EC.Framework.Domain
{
    [DependsOn(
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpLocalizationModule)
        )]
    public class FrameworkDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<FrameworkDomainModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<FrameworkResource>("zh-Hans")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Framework");

                options.DefaultResourceType = typeof(FrameworkResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Framework", typeof(FrameworkResource));
            });
        }
    }
}