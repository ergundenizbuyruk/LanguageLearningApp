using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Languages
{
    public class LanguageAppService : AsyncCrudAppService<Language, LanguageDto>, ILanguageAppService
    {
        public LanguageAppService(IRepository<Language, int> repository) : base(repository)
        {
        }
    }

    public interface ILanguageAppService: IAsyncCrudAppService<LanguageDto> { }
}
