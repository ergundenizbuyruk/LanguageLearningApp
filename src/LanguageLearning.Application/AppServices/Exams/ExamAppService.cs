using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Exams
{
    public class ExamAppService : AsyncCrudAppService<Exam, ExamDto>, IExamAppService
    {
        public ExamAppService(IRepository<Exam, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }

    public interface IExamAppService : IAsyncCrudAppService<ExamDto>
    {

    }
}
