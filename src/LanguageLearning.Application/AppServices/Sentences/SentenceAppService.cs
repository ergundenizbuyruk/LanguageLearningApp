using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Sentences
{
    public class SentenceAppService : AsyncCrudAppService<Sentence, SentenceDto>, ISentenceAppService
    {
        public SentenceAppService(IRepository<Sentence, int> repository) : base(repository)
        {
        }
    }

    public interface ISentenceAppService: IAsyncCrudAppService<SentenceDto> { }

}
