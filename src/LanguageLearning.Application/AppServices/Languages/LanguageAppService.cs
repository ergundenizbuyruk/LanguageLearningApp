using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Languages.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Languages
{
    public class LanguageAppService : AsyncCrudAppService<Language, LanguageDto, int, LanguageDto, LanguageCreateDto, LanguageUpdateDto>, ILanguageAppService
    {
        public LanguageAppService(IRepository<Language, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;

    }

    public interface ILanguageAppService: IAsyncCrudAppService<LanguageDto, int, LanguageDto, LanguageCreateDto, LanguageUpdateDto> { }
}
