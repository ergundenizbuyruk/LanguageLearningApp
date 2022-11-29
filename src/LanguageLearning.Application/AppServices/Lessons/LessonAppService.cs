using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Lessons
{
    public class LessonAppService : AsyncCrudAppService<Lesson, LessonDto>, ILessonAppService
    {
        public LessonAppService(IRepository<Lesson, int> repository) : base(repository)
        {
        }
    }


    public interface ILessonAppService : IAsyncCrudAppService<LessonDto> { }
}
