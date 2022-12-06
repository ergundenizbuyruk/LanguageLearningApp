using Abp.Application.Services;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Comments.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using Microsoft.AspNetCore.Authorization;

namespace LanguageLearning.AppServices.Comments
{
    [Authorize]
    public class CommentAppService : AsyncCrudAppService<Comment, CommentDto, int, CommentDto, CommentCreateDto, CommentUpdateDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, int> repository) : base(repository)
        {
        }

        protected override string CreatePermissionName { get; set; } = PermissionNames.Student;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Student;
    }

    public interface ICommentAppService : IAsyncCrudAppService<CommentDto, int, CommentDto, CommentCreateDto, CommentUpdateDto>
    {

    }
}
