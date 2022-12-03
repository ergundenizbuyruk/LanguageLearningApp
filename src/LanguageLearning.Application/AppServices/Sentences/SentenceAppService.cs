using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using LanguageLearning.Authorization;
using LanguageLearning.Authorization.Roles;
using LanguageLearning.Domain.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Sentences
{

    [AbpAuthorize]
    public class SentenceAppService : AsyncCrudAppService<Sentence, SentenceDto>, ISentenceAppService
    {
        public SentenceAppService(IRepository<Sentence, int> repository) : base(repository)
        {
        }

        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }

    public interface ISentenceAppService: IAsyncCrudAppService<SentenceDto> { }

}
