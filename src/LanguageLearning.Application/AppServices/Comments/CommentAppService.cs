using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LanguageLearning.AppServices.Comments.Dtos;
using LanguageLearning.Authorization;
using LanguageLearning.Domain;
using System.Threading.Tasks;

namespace LanguageLearning.AppServices.Comments
{
    public class CommentAppService : AsyncCrudAppService<Comment, CommentDto, int, CommentDto, CommentCreateDto, CommentUpdateDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, int> repository) : base(repository)
        {
        }
        protected override string DeletePermissionName { get; set; } = PermissionNames.Admin;

        protected override string CreatePermissionName { get; set; } = PermissionNames.Admin;

        protected override string UpdatePermissionName { get; set; } = PermissionNames.Admin;


        public override Task<PagedResultDto<CommentDto>> GetAllAsync(CommentDto input)
        {
            return base.GetAllAsync(input);
        }


        public override Task<CommentDto> CreateAsync(CommentCreateDto input)
        {
            return base.CreateAsync(input);
        }


        public override Task<CommentDto> UpdateAsync(CommentUpdateDto input)
        {
            return base.UpdateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<CommentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }



    }

    public interface ICommentAppService : IAsyncCrudAppService<CommentDto, int, CommentDto, CommentCreateDto, CommentUpdateDto>
    {

    }
}
