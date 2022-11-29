using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments
{
    public class CommentAppService : AsyncCrudAppService<Comment, CommentDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, int> repository) : base(repository)
        {
        }
    }

    public interface ICommentAppService : IAsyncCrudAppService<CommentDto>
    {

    }
}
