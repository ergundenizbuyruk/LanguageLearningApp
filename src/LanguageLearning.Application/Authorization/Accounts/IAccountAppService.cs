using Abp.Application.Services;
using LanguageLearning.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace LanguageLearning.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
