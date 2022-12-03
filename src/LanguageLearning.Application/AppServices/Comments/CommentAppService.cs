using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;

namespace LanguageLearning.AppServices.Comments
{
    public class CommentAppService : AsyncCrudAppService<Comment, CommentDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;
    }

    public interface ICommentAppService : IAsyncCrudAppService<CommentDto>
    {

    }
}
