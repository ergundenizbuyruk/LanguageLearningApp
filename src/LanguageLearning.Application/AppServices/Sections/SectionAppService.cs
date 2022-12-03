using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Sections;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Sections
{
    public class SectionAppService : AsyncCrudAppService<Section, SectionDto>, ISectionAppService
    {
        public SectionAppService(IRepository<Section, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;

    }



    public interface ISectionAppService : IAsyncCrudAppService<SectionDto> { }
}

