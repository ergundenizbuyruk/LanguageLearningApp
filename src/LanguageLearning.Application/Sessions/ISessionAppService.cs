using Abp.Application.Services;
using LanguageLearning.Sessions.Dto;
using System.Threading.Tasks;

namespace LanguageLearning.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
