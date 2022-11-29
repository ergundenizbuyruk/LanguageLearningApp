using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Words
{
    public class WordAppService : AsyncCrudAppService<Word, WordDto>, IWordAppService
    {
        public WordAppService(IRepository<Word, int> repository) : base(repository)
        {
        }
    }

    public interface IWordAppService: IAsyncCrudAppService<WordDto> { }
}
