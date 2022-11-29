using Abp.Application.Services;
using LanguageLearning.MultiTenancy.Dto;

namespace LanguageLearning.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

