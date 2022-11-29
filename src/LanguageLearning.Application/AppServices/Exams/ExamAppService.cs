using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Exams
{
    public class ExamAppService : AsyncCrudAppService<Exam, ExamDto>, IExamAppService
    {
        public ExamAppService(IRepository<Exam, int> repository) : base(repository)
        {
        }
    }

    public interface IExamAppService : IAsyncCrudAppService<ExamDto>
    {

    }
}
