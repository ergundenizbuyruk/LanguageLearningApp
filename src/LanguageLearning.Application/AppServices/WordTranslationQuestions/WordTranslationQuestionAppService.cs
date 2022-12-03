using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.WordTranslationQuestions
{
    public class WordTranslationQuestionAppService : AsyncCrudAppService<WordTranslationQuestion, WordTranslationQuestionDto>, IWordTranslationQuestionAppService
    {
        public WordTranslationQuestionAppService(IRepository<WordTranslationQuestion, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }
    public interface IWordTranslationQuestionAppService : IAsyncCrudAppService<WordTranslationQuestionDto> { }
}
