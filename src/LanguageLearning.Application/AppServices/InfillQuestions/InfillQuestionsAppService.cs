using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.InfillQuestions
{
    public class InfillQuestionsAppService : AsyncCrudAppService<InfillQuestion, InfillQuestionsDto>, IInfillQuestionsAppService
    {
        public InfillQuestionsAppService(IRepository<InfillQuestion, int> repository) : base(repository)
        {
        }
    }
    public interface IInfillQuestionsAppService : IAsyncCrudAppService<InfillQuestionsDto>
    {

    }
}
