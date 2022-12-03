using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Authorization;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.SentenceTranslationQuestions
{
    public class SentenceTranslationQuestionAppService : AsyncCrudAppService<SentenceTranslationQuestion, SentenceTranslationQuestionDto> , ISentenceTranslationQuestionAppService
    {
        public SentenceTranslationQuestionAppService(IRepository<SentenceTranslationQuestion, int> repository) : base(repository)
        {
        }

        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }
    public interface ISentenceTranslationQuestionAppService: IAsyncCrudAppService<SentenceTranslationQuestionDto> { }
}
