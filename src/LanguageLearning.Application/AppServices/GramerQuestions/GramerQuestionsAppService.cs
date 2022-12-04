using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.GramerQuestions.Dtos;
using LanguageLearning.Domain.Questions;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.GramerQuestions
{
    public class GramerQuestionsAppService : IGramerQuestionsAppService
    {
        private readonly IRepository<GramerQuestion> _gramerQuestions;

        public GramerQuestionsAppService(IRepository<GramerQuestion> gramerQuestions)
        {
            _gramerQuestions = gramerQuestions;
        }

        public Task<GramerQuestionCreateOutputDto> Create(GramerQuestionCreateDto input)
        {
            return null;
        }
    }

    public interface IGramerQuestionsAppService : IApplicationService { }
}
